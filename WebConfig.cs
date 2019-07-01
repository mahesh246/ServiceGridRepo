using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace Armstrong.Services.Web.Inventory
{
    public static class WebConfig
    {
        public static string LnEndPointAddress {
            get { return WebConfigurationManager.AppSettings["LnEndPointAddress"]; }
        }
    }
}