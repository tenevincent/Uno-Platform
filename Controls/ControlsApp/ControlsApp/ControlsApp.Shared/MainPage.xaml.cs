using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ControlsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            // https://docs.microsoft.com/de-de/windows/apps/design/controls/dialogs-and-flyouts/dialogs
            this.InitializeComponent();
        }

        /// <summary>
        /// https://docs.microsoft.com/de-de/windows/apps/design/controls/dialogs-and-flyouts/dialogs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog noWifiDialog = new ContentDialog
            {
                Title = "No wifi connection",
                Content = "Check your connection and try again.",
                CloseButtonText = "Ok",
                BorderBrush = new SolidColorBrush(Colors.Green),
                BorderThickness = new Thickness(1)
            };

            ContentDialogResult result = await noWifiDialog.ShowAsync();
        }

        private async void DoOkCancelDialog_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog deleteFileDialog = new ContentDialog
            {
                Title = "Delete file permanently?",
                Content = "If you delete this file, you won't be able to recover it. Do you want to delete it?",
                PrimaryButtonText = "Delete",
                DefaultButton = ContentDialogButton.Close,
                CloseButtonText = "Cancel",
                BorderBrush = new SolidColorBrush(Colors.Green),
                BorderThickness = new Thickness(1)

            };

            ContentDialogResult result = await deleteFileDialog.ShowAsync();

            // Delete the file if the user clicked the primary button.
            /// Otherwise, do nothing.
            if (result == ContentDialogResult.Primary)
            {
                // Delete the file.
            }
            else
            {
                // The user clicked the CLoseButton, pressed ESC, Gamepad B, or the system back button.
                // Do nothing.
            }
        }

        private async void DoBlockDialog_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog locationPromptDialog = new ContentDialog
            {
                Title = "Allow AppName to access your location?",
                Content = "AppName uses this information to help you find places, connect with friends, and more.",
                CloseButtonText = "Block",
                PrimaryButtonText = "Allow",
                BorderBrush = new SolidColorBrush(Colors.Green),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(5)
            };

            ContentDialogResult result = await locationPromptDialog.ShowAsync();
        }

        private async void DoDialogDreiButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog subscribeDialog = new ContentDialog
            {
                Title = "Subscribe to App Service?",
                Content = "Listen, watch, and play in high definition for only $9.99/month. Free to try, cancel anytime.",
                CloseButtonText = "Not Now",
                PrimaryButtonText = "Subscribe",
                SecondaryButtonText = "Try it",
                DefaultButton = ContentDialogButton.Primary,
                BorderBrush = new SolidColorBrush(Colors.Green),
                BorderThickness = new Thickness(1),
                CornerRadius = new CornerRadius(10)
            };

            ContentDialogResult result = await subscribeDialog.ShowAsync();
        }

            
    }
}
