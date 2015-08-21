using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UniversalTestApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (MainSplitView.DisplayMode == SplitViewDisplayMode.CompactOverlay)
            {
                MainSplitView.DisplayMode = SplitViewDisplayMode.Inline;
            }
            else
            {
                MainSplitView.DisplayMode = SplitViewDisplayMode.CompactOverlay;
            }
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new MessageDialog("Hello World");
            dialog.ShowAsync();
        }

        private void ButtonChangeColore_OnClick(object sender, RoutedEventArgs e)
        {
            var random = new Random();
            var a = BitConverter.GetBytes(random.Next(254))[0];
            var r = BitConverter.GetBytes(random.Next(254))[0];
            var g = BitConverter.GetBytes(random.Next(254))[0];
            var b = BitConverter.GetBytes(random.Next(254))[0];
            scvMain.Background = new SolidColorBrush(Color.FromArgb(a, r, g, b));
        }
    }
}
