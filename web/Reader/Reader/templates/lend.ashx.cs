using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Reader.templates
{
    /// <summary>
    /// vdetails 的摘要说明
    /// </summary>
    public class vdetails : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
           
            string vid = context.Request["vid"];
            
            if (string.IsNullOrEmpty(vid))
            {
                context.Response.Redirect("search.htm");
            }
           
            var Data = new {};
            string html = CommonHelper.RenderHtml("lend.htm", Data);
            context.Response.Write(html);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}