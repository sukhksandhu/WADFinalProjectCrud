using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_Pages_Sukhdeep
{
    public partial class ViewPages : System.Web.UI.Page
    {
        //THIS PAGE IS CALLED WHEN SOMEONE CLICK ON PAGE TITLES IN HEADER 
        protected void Page_Load(object sender, EventArgs e)
        {
            //TAKING ID OF PAGE AND PASSING QUERY 

            string page_id = Request.QueryString["pageid"];

            string query = "select * from pageshttp where pageid = " + page_id;

            var db = new Page_db();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                
                //DISPLAYING PAGE 
                string pagetitle = row["pagetitle"];
                page_title.InnerHtml += "<div class=\"col2\">" + pagetitle + "</div>";
                string pagebody = row["pagebody"];
                page_body.InnerHtml += "<div class=\"col2last\">" + pagebody + "</div>";



            }
        }
    }
}