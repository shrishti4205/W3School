﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3SchoolSpecflow_Assignment1.Interface;
using W3SchoolSpecflow_Assignment1.Settings;

namespace W3SchoolSpecflow_Assignment1.Configurations
{
    public class AppConfigReader : IConfig

    {
        public BrowserType GetBrowser()
        {
            String browser = ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser);
            return (BrowserType)Enum.Parse(typeof(BrowserType), browser);
        }

        public string GetWebsite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Website);
        }
    }
}
