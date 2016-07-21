using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CourseraCssResponsive
{
    public static class Logic
    {
       public static List< tbl_CoustomerDetails> GetData()
       {
           try
           {
               ResponsivewebEntities1 Db = new ResponsivewebEntities1();
               Db.Configuration.ProxyCreationEnabled = false;
               List<tbl_CoustomerDetails> result = (from cd in Db.tbl_CoustomerDetails
                                                    select cd).ToList();
               return result;
           }
           catch (Exception)
           {
               return null;
               
           }
          
            
       }
    }
}