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
        private string _header;
        public string Header
        {
            get { return _header; }
            set { _header = value; }
        }
        private string _bg1;
        public string Bg1
        {
            get { return _bg1; }
            set { _bg1 = value; }
        }
        private string _bg2;
        public string Bg2
        {
            get { return _bg2; }
            set { _bg2 = value; }
        }
        private string _textColor;
        public string TextColor
        {
            get { return _textColor; }
            set { _textColor = value; }
        }
        public MainWindow()
        {
            bool whiteTheme = Properties.Settings.Default.whiteTheme;
            LoadTheme(whiteTheme);
            InitializeComponent();
            this.DataContext = this;
        }
        public void LoadTheme(bool white)
        {
            if(white)
            {
                Header = "/images/FileTeleporterHeaderLogoWhiteTheme.png";
                Bg1 = "white" ;
                Bg2 = "#e6e6e6";
                TextColor = "black";
            }
            else
            {
                Header = "/images/FileTeleporterHeaderLogo.png";
                Bg1 = "#242429";
                Bg2 = "#2d2d32";
                TextColor = "white";
            }
        }
    }
}
