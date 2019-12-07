using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_Pages_Sukhdeep
{
    public partial class DeletePages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void delete_function(object sender, EventArgs e)
        {
            string query = "delete from pageshttp where pageid=" + Request.QueryString["pageid"];
            var db = new Page_db();
            db.applyQuery(query);
            Response.Redirect("ListPages.aspx");
        }
    }
}