using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3SchoolSpecflow_Assignment1.Settings;

namespace W3SchoolSpecflow_Assignment1.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(String url)
        {
            ObjectRepository.Driver.Navigate().GoToUrl(url);

        }
    }
}
