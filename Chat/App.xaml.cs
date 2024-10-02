using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;

namespace Chat
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            base.OnStartup(e);
            IWiki wiki = new Wiki(httpClient);

            MainWindow mw = new MainWindow(wiki);
            mw.Show();
        }
    }
}