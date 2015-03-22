﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BanditsModel;
using System.Web.Security;

namespace Bandits.Utils
{
    public static class UserManagement
    {
        public static WebUser GetCurrentWebUser()
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated && HttpContext.Current.Session != null)
            {
                WebUser user = HttpContext.Current.Session["CurrentUser"] as WebUser;

                if (user != null)
                {
                    if (HttpContext.Current.User.Identity.Name == user.Email)
                    {
                        return user;
                    }
                }
                else
                {
                    using (WebUsersController c = new WebUsersController())
                    {
                        WebUser lookupUser = c.GetWhere(u => u.Email == HttpContext.Current.User.Identity.Name).First();
                        if (lookupUser != null)
                        {
                            BindWebUserToSession(lookupUser);
                            return lookupUser;
                        }
                    }
                }
            }

            return null;
        }

        public static bool BindWebUserToSession(WebUser user)
        {
            if (HttpContext.Current.User.Identity.IsAuthenticated && HttpContext.Current.Session != null)
            {
                // Check to make sure that the identity username in forms auth is the same as this users identity... 
                // we need to assume that forms auth has the correctly logged in user
                if (HttpContext.Current.User.Identity.Name == user.Email)
                {
                    HttpContext.Current.Session["CurrentUser"] = user;
                    return true;
                }
            }

            return false;
        }
    }
}