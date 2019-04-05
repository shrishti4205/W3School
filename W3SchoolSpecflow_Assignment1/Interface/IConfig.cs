using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3SchoolSpecflow_Assignment1.Configurations;

namespace W3SchoolSpecflow_Assignment1.Interface
{
   public interface IConfig
    {
        BrowserType GetBrowser();
        String GetWebsite();
    }
}
