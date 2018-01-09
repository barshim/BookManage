using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Reader;
using System.Data.SqlClient;

namespace Reader.templates
{
    /// <summary>
    /// details 的摘要说明
    /// </summary>
    public class details : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";

            string cid=context.Request["cid"];
            DataTable dt = new DataTable();
            DataTable dtnm = new DataTable();
            DataTable dtv = new DataTable();
            if (string.IsNullOrEmpty(cid))
            {
                context.Response.Redirect("search.htm");
            }
            else
            {
                dt = SqlHelper.ExecuteDataTable("select * from caseBook where caseID = @tx",
                       new SqlParameter("@tx", cid));
                dtnm = SqlHelper.ExecuteDataTable("select caseName from caseBook where caseID = @tx",
                       new SqlParameter("@tx", cid));
                dtv = SqlHelper.ExecuteDataTable("select * from vsch where caseID=@tx", 
                    new SqlParameter("@tx", cid));
            }
            var Data = new { cbook = dt.Rows ,name=dtnm.Rows[0][0],vbook=dtv.Rows};
            string html = CommonHelper.RenderHtml("cdetails.htm", Data);
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