using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1123
{
    public static class ConfigCommon
    {
        public static string Domain_URL
        {
            get
            {
                var root_url = System.Configuration.ConfigurationManager.AppSettings["DOMAIN_URL"] == null ? "http://localhost:51227" :
                    System.Configuration.ConfigurationManager.AppSettings["DOMAIN_URL"].ToString();
                return root_url;
            }

        }

    }
}
