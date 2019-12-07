using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_Pages_Sukhdeep
{
    public partial class AddNewPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
            protected void Add_Page(object sender, EventArgs e)
            {
                //create connection
                Page_db db = new Page_db();

              
                HTTPPage new_page = new HTTPPage();
               
                new_page.SetTitle(page_title.Text);
                new_page.SetBody(page_body.Text);
               

                //add the page to the database
                db.AddPage(new_page);


                Response.Redirect("ListPages.aspx");
            }
        
    }
}