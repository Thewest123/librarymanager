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

namespace LibraryManager.Pages
{
    /// <summary>
    /// Interakční logika pro SettingsPage.xaml
    /// </summary>
    public partial class SettingsPage
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void ThemeSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            ThemeManager.Current.ApplicationTheme = ThemeSwitch.IsOn ? ApplicationTheme.Light : ApplicationTheme.Dark;

            Properties.Settings.Default.AppTheme = ThemeSwitch.IsOn ? "light" : "dark";
            Properties.Settings.Default.Save();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ThemeSwitch.IsOn = (ThemeManager.Current.ApplicationTheme == ApplicationTheme.Light);
        }
    }
}
