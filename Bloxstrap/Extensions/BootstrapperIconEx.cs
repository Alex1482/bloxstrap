﻿using System;
using System.Drawing;

using Bloxstrap.Enums;

namespace Bloxstrap.Extensions
{
    static class BootstrapperIconEx
    {
        // small note on handling icon sizes
        // i'm using multisize icon packs here with sizes 16, 24, 32, 48, 64 and 128
        // use this for generating multisize packs: https://www.aconvert.com/icon/

        public static Icon GetIcon(this BootstrapperIcon icon)
        {
            // load the custom icon file
            if (icon == BootstrapperIcon.IconCustom)
            {
                Icon? customIcon = null;

                try
                {
                    customIcon = new Icon(App.Settings.Prop.BootstrapperIconCustomLocation);
                }
                catch (Exception ex)
                {
                    App.Logger.WriteLine($"[BootstrapperIconEx::GetIcon] Failed to load custom icon! {ex}");
                }

                return customIcon ?? Properties.Resources.IconBloxstrap;
            }

            return icon switch
            {
                BootstrapperIcon.IconBloxstrap => Properties.Resources.IconBloxstrap,
                BootstrapperIcon.Icon2009 => Properties.Resources.Icon2009,
                BootstrapperIcon.Icon2011 => Properties.Resources.Icon2011,
                BootstrapperIcon.IconEarly2015 => Properties.Resources.IconEarly2015,
                BootstrapperIcon.IconLate2015 => Properties.Resources.IconLate2015,
                BootstrapperIcon.Icon2017 => Properties.Resources.Icon2017,
                BootstrapperIcon.Icon2019 => Properties.Resources.Icon2019,
                BootstrapperIcon.Icon2022 => Properties.Resources.Icon2022,
                _ => Properties.Resources.IconBloxstrap
            };
        }
    }
}
