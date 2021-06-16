/*
 * Copyright (C) 2021  Jolan Aklin And Yohan Zbinden

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <https://www.gnu.org/licenses/>.
 */
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
        public classes.Data Data;
        public MainWindow()
        {
            bool whiteTheme = Properties.Settings.Default.whiteTheme;
            InitializeComponent();
            this.Data = new classes.Data(whiteTheme);
            this.DataContext = this.Data;
        }

        private void OpenSettings(object sender, MouseButtonEventArgs e)
        {
            dialogs.Settings s = new dialogs.Settings(this);
            s.Show();
        }
        /// <summary>
        /// called by the setting dialog when saving settings so it automatically update the theme
        /// since the dialog directly edit the public property theme it does not required to pass an argument
        /// </summary>
        public void onSettingsUpdate()
        {
            this.DataContext = this.Data;
        }
    }
}
