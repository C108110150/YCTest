using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;

namespace YCTest.Helper
{
    public class CommonRazorFunctions
    {
        public static string GetAntiForgeryToken()
        {
            string cookieToken, formToken;
            AntiForgery.GetTokens(null, out cookieToken, out formToken);
            return string.Concat(cookieToken, ":", formToken);
        }
    }
}