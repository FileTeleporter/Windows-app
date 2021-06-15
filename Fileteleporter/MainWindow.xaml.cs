using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
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

namespace Fileteleporter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private classes.Theme theme;
        public MainWindow()
        {
            bool whiteTheme = Properties.Settings.Default.whiteTheme;
            InitializeComponent();
            this.theme = new classes.Theme(whiteTheme);
            this.DataContext = this.theme;
        }

        private void OpenSettings(object sender, MouseButtonEventArgs e)
        {
            dialogs.Settings s = new dialogs.Settings(this.theme);
            s.Show();
        }
    }
}
