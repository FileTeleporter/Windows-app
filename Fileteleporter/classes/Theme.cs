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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fileteleporter.classes
{
    public class Theme
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
        private string _hoverColor;
        public string HoverColor
        {
            get { return _hoverColor; }
            set { _hoverColor = value; }
        }
        public Theme (bool white)
        {
            if (white)
            {
                Header = "/images/FileTeleporterHeaderLogoWhiteTheme.png";
                Bg1 = "white";
                Bg2 = "#e6e6e6";
                TextColor = "black";
                HoverColor = "#41aff5";
            }
            else
            {
                Header = "/images/FileTeleporterHeaderLogo.png";
                Bg1 = "#242429";
                Bg2 = "#2d2d32";
                TextColor = "white";
                HoverColor = "#0772b9";
            }
        }
    }
}
