﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Security;
using Bandits;
using System.Web.Script.Serialization;
using Bandits.Providers.Security;
using System.Security.Principal;

namespace Bandits
{
    public partial class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
           this.ConfigureWebApi();

            // Code that runs on application startup
            AuthConfig.RegisterOpenAuth();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        void Application_End(object sender, EventArgs e)
        {
            //  Code that runs on application shutdown

        }

        void Application_Error(object sender, EventArgs e)
        {
            // Code that runs when an unhandled error occurs

        }
    }
}
