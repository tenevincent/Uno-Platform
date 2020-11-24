using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FirstApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        private double value = 10;
        public MainPage()
        {
            this.InitializeComponent();


            var progressBar = new ProgressBar() { Value = value, Margin = new Thickness(5) };

            var stackPanel = new StackPanel();

            var firstButton = new Button() { Content = "Click here" };
            firstButton.Click += (sender, args) =>
            {
                value++;
                progressBar.Value = value;
            };
            stackPanel.Children.Add(firstButton);
            stackPanel.Children.Add(new Button() { Content = "Click here" });
            stackPanel.Children.Add(new TextBlock() { Text = "Click here" });
            stackPanel.Children.Add(progressBar);


            //this.Content = stackPanel;
        }

        private void SayHello(object sender, RoutedEventArgs e)
        {
            HelloLabel.Text = "Hello, " + FirstName.Text;
        }



    }
}
