using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;

namespace Chat
{
    public interface IWiki
    {
        public Task<string> GetResult(string input);
    }
    
    public class Wiki : IWiki
    {
        private HttpClient HttpClient { get; }
    
        public Wiki(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
    
        public async Task<string> GetResult(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "You didn't write anything.";
            }
            string output = string.Empty;
            var request = $"https://en.wikipedia.org/w/api.php?action=query&format=xml&prop=extracts&titles={Uri.EscapeDataString(input)}&exintro=1&explaintext=1";

            try
            {
                HttpResponseMessage response = await HttpClient.GetAsync(request);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStreamAsync();
                    XmlReaderSettings settings = new XmlReaderSettings { Async = true };

                    using (var reader = XmlReader.Create(data, settings))
                    {
                        while (await reader.ReadAsync())
                        {
                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "extract")
                            {
                                await reader.ReadAsync();
                                output = reader.Value;
                            }
                        }
                    }
                    if (string.IsNullOrEmpty(output))
                    {
                        return "Your input wasn't found on Wikipedia";
                    }
                    return output;
                }

                // Handle specific HTTP status codes
                if (response.StatusCode == HttpStatusCode.NotFound)
                {
                    return "Page not found on Wikipedia";
                }
                return $"Error: {response.StatusCode}";
            }
            catch (HttpRequestException)
            {
                // Handle network-related errors
                return "Unable to connect to Wikipedia. Please check your internet connection.";
            }
            catch (Exception)
            {
                // Handle other exceptions
                return "An unexpected error occurred.";
            }
        }

    }

}