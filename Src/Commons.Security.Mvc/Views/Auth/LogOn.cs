﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BoC.Security.Mvc.Views.Auth
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Collections;
    using System.Collections.Specialized;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Web.Caching;
    using System.Web.DynamicData;
    using System.Web.SessionState;
    using System.Web.Profile;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Web.UI.HtmlControls;
    using System.Xml.Linq;
    using DotNetOpenAuth.Mvc;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MvcRazorClassGenerator", "1.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Auth/LogOn.cshtml")]
    public class _Page_Views_Auth_LogOn_cshtml : System.Web.Mvc.WebViewPage<BoC.Security.Mvc.ViewModels.LogOnModel>
    {
#line hidden

        public _Page_Views_Auth_LogOn_cshtml()
        {
        }
        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {



  
    ViewBag.Title = "Log On";



DefineSection("head", () => {

WriteLiteral("\n    ");


Write(MvcHtmlString.Create(Html.OpenIdSelectorStyles()));

WriteLiteral("\n");


});

WriteLiteral("\n\n");


Write(Html.ValidationSummary(true, "Login was unsuccessful. Please correct the errors and try again."));

WriteLiteral("\n");


Write(Html.ValidationMessage("_FORM"));

WriteLiteral("\n");


Write(Html.Partial("_LogonOpenId"));

WriteLiteral("\n");


Write(Html.Partial("_LogonNative"));

WriteLiteral("\n");


        }
    }
}
