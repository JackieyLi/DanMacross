﻿using System;
using System.Collections.Generic;
using System.Text;
#if ANDROID
using FormsPlugin.Iconize.Droid; 
#elif WINDOWS_UWP
using FormsPlugin.Iconize.UWP;
#elif __IOS__
using FormsPlugin.Iconize.iOS;
#endif

namespace DanMacross
{
    public static class Initialization
    {
        public static void Init()
        {
            Plugin.Iconize.Iconize.With(new Plugin.Iconize.Fonts.FontAwesomeModule());
            IconControls.Init();
        }
    }
}
