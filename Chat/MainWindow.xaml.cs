using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private IWiki _wiki;
        private int _borderIndex = 0;
        public MainWindow(IWiki wiki)
        {
            InitializeComponent();
            _wiki = wiki;
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) 
                DragMove();
        }

        private void ButtonMinimize_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        }

        private void ButtonMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (Application.Current.MainWindow.WindowState != WindowState.Maximized)
                Application.Current.MainWindow.WindowState = WindowState.Maximized;
            else Application.Current.MainWindow.WindowState = WindowState.Normal;
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        
        
        private async void FunButton_Click(object sender, RoutedEventArgs e)
        {
            FunImage.Width = 400;
            FunImage.Height = 400;
            
            Random random = new Random();
            
            int randomNumber = random.Next(2);
            string imageSource;
            if (randomNumber == 0)
            {
                imageSource = "/Icons/nerdV2.png";
            }
            else
            {
                imageSource = "/Icons/nerd.png";
            }
            
            FunImage.Visibility = Visibility.Visible;
            FunImage.Source = new BitmapImage(new Uri(imageSource, UriKind.Relative));
            
            await Task.Delay(3000);

            FunImage.Visibility = Visibility.Collapsed;
            }

        private async void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string input = Input.Text;
            string capitalized = input.ToLower();
            string output = await _wiki.GetResult(capitalized);

            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("HH:mm");

            Add($"User {formattedTime}: {input}");
            _borderIndex++;
            Add($"MaggieChat {formattedTime}: {output}");
            _borderIndex++;

            Input.Text = "";
            ChatScrollViewer.ScrollToEnd();
        }
        

        private void Add(string input)
        {
            Grid contentGrid = new Grid();
            ColumnDefinition column1 = new ColumnDefinition();
            column1.Width = new GridLength(30); // Width of the image column
            ColumnDefinition column2 = new ColumnDefinition();
            column2.Width = new GridLength(1, GridUnitType.Star); // Remaining width for the text
            contentGrid.ColumnDefinitions.Add(column1);
            contentGrid.ColumnDefinitions.Add(column2);


            Border border = new Border();
            border.Margin = new Thickness(15);
            border.CornerRadius = new CornerRadius(8);
            if (_borderIndex % 2 == 0)
            {
                border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#1C6590"));
            }
            else
            {
                border.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#0E3952"));
            }
            border.Background.Opacity = 0.7;
            border.HorizontalAlignment = HorizontalAlignment.Left;


            Ellipse ellipse = new Ellipse();
            ellipse.Width = 25;
            ellipse.Height = 25;
            ellipse.Fill =
                new SolidColorBrush((Color)ColorConverter.ConvertFromString("#3887B5")); // Fill color of the circle
            Grid.SetColumn(ellipse, 0); // Place the ellipse in the first column

            Image image = new Image();
            if (_borderIndex % 2 == 0)
            {
                image.Source = new BitmapImage(new Uri(@"/Icons/user.png", UriKind.Relative));
            }
            else
            {
                image.Source = new BitmapImage(new Uri(@"/Icons/mc.png", UriKind.Relative));
            }

            image.Width = 20;
            image.Height = 20;
            image.Stretch = Stretch.Uniform;
            image.Clip = new EllipseGeometry(new Point(10, 10), 10, 10); // Clip the image to the circle shape
            Grid.SetColumn(image, 0); // Place the image in the first column


            TextBlock textBlock = new TextBlock();
            textBlock.Text = input;
            textBlock.Foreground = Brushes.White;
            textBlock.TextWrapping = TextWrapping.Wrap;
            textBlock.Margin = new Thickness(10); // Adjust margin as needed
            Grid.SetColumn(textBlock, 1); // Place the text in the second column


            contentGrid.Children.Add(ellipse);
            contentGrid.Children.Add(image);
            contentGrid.Children.Add(textBlock);
            border.Child = contentGrid;
            AddStackPanel.Children.Add(border);
        }
    }
}