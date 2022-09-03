using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
namespace SmartTech.UI.Controllers
{
    public class BaseController : Controller
    {
        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            Exception exception = filterContext.Exception;

            //Logging
            string cs = @"server=.;database=SmartTech;uid=sa;pwd=123";
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into LogError(Date,Controller,Action,Exception,Ip) values(@date,@controller,@action,@exception,@ip)";
            cmd.Parameters.AddWithValue("@date", DateTime.Now);
            cmd.Parameters.AddWithValue("@controller", filterContext.RouteData.Values["controller"]);
            cmd.Parameters.AddWithValue("@action", filterContext.RouteData.Values["action"]);
            cmd.Parameters.AddWithValue("@exception", exception.Message);


            string ip = HttpContext.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ip))
            {
                ip = HttpContext.Request.ServerVariables["REMOTE_ADDR"];
            }

            cmd.Parameters.AddWithValue("@ip", ip);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            //Logging

            filterContext.Result = new RedirectResult("/Default/Error");
        }
    }
}