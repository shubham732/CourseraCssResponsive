﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace CourseraCssResponsive
{
    /// <summary>
    /// Summary description for webService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]

    public class webService : System.Web.Services.WebService
    {

        [WebMethod]
     
        public  List<tbl_CoustomerDetails> HelloWorld()
        {
            return Logic.GetData();
        }
    }
}
