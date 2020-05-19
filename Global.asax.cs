﻿using ItTrainig.Models;
using ItTrainingModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace ItTrainig
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
        //protected void Session_Start()
        //{
        //    Application.Lock();
        //    Application["TotalofVisitor"] = (int)Application["TotalofVisitor"] + 1;
        //    Application.UnLock();
        //}


        //protected void Application_PostAuthenticateRequest()
        //{
        //    HttpCookie authoCookies = Request.Cookies[FormsAuthentication.FormsCookieName];
        //    if (authoCookies != null)
        //    {
        //        FormsAuthenticationTicket ticket = FormsAuthentication.Decrypt(authoCookies.Value);
        //        JavaScriptSerializer js = new JavaScriptSerializer();
        //        AdminProfileData user = js.Deserialize<AdminProfileData>(ticket.UserData);
        //        MyAdminIdentity myIdentity = new MyAdminIdentity(user);
        //        MyAdminPrincipal myPrincipal = new MyAdminPrincipal(myIdentity);
        //        HttpContext.Current.User = myPrincipal;
        //    }
        //}
    }
}
