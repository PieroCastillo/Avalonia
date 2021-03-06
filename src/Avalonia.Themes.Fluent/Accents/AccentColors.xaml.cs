﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using Avalonia.Platform;
using Avalonia.Styling;

namespace Avalonia.Themes.Fluent.Accents
{
    public class AccentColors : Styles
    {
        public AccentColors()
        {
            AvaloniaXamlLoader.Load(this);

            var accentColor_prov = AvaloniaLocator.CurrentMutable.GetService<IPlatformAccentColorProvider>();

            var accentcolor = accentColor_prov == null ? Color.Parse("#FF0078D7") : accentColor_prov.AccentColor;
            
            var light1 = Color.ChangeColorLuminosity(accentcolor, 0.3);
            var light2 = Color.ChangeColorLuminosity(accentcolor, 0.5);
            var light3 = Color.ChangeColorLuminosity(accentcolor, 0.7);
            var dark1 = Color.ChangeColorLuminosity(accentcolor, -0.3);
            var dark2 = Color.ChangeColorLuminosity(accentcolor, -0.5);
            var dark3 = Color.ChangeColorLuminosity(accentcolor, -0.7);


            this.Resources.Add("SystemAccentColor", accentcolor);
            this.Resources.Add("SystemAccentColorLight1", light1);
            this.Resources.Add("SystemAccentColorLight2", light2);
            this.Resources.Add("SystemAccentColorLight3", light3);
            this.Resources.Add("SystemAccentColorDark1", dark1);
            this.Resources.Add("SystemAccentColorDark2", dark2);
            this.Resources.Add("SystemAccentColorDark3", dark3);
        }
    }
}
