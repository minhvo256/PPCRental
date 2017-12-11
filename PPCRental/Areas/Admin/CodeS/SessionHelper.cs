using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PPCRental.Areas.Admin.CodeS
{
    public class SessionHelper
    {
        public static void SetSession(UserSession session)
        {
            HttpContext.Current.Session["login session"] = session;

        }

        public static UserSession GetSession()
        {
            var session = HttpContext.Current.Session["login session"];
            if (session == null)
                return null;
            else
                return session as UserSession;
        }
    }
}