using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ModernWpf;
using ModernWpf.Controls;
using LibraryManager.Properties;
using Page = System.Windows.Controls.Page;

namespace LibraryManager
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Navigate(typeof(Pages.Page1));
            SetAppTheme();

            //DemoData.PopulateWithDemoData();
        }

        private void NavigationView_OnSelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if(args.IsSettingsSelected) Navigate(typeof(Pages.SettingsPage));
            else Navigate(args.SelectedItem);

            NavigationView.Header = (args.SelectedItem as NavigationViewItem).Content;
        }

        private void Navigate(object item)
        {
            if (item is NavigationViewItem menuItem)
            {
                Type pageType = menuItem.Tag as Type;
                if (ContentFrame.CurrentSourcePageType != pageType)
                {
                    ContentFrame.Navigate(pageType);
                }
            }
        }

        private void Navigate(Type sourcePageType)
        {
            if (ContentFrame.CurrentSourcePageType != sourcePageType)
            {
                ContentFrame.Navigate(sourcePageType);
            }
        }

        private void SetAppTheme()
        {
            if (Properties.Settings.Default.AppTheme == "light") ThemeManager.Current.ApplicationTheme = ApplicationTheme.Light;
            if (Properties.Settings.Default.AppTheme == "dark") ThemeManager.Current.ApplicationTheme = ApplicationTheme.Dark;
        }
    }
}
