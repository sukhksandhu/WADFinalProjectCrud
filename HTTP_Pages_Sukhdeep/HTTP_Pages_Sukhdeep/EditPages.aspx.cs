using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_Pages_Sukhdeep
{
    //REFERENCED CODE FROM CHRISTINE BITTLE,
//*https://github.com/christinebittle/crud_essentials*/, ON DEC 3 ,2019 FOR FINAL PROJECT FOR SCHOOL 
    public partial class EditPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                Page.Validate();
                if (Page.IsValid)
                {
                    string page_record = Request.QueryString["pageid"];
                    var database = new Page_db();
                    string my_page_title = page_title.Text;
                    string my_page_body = page_body.Text;
                    //UPDATE TITLE AND BODY 
                    string query = "update pageshttp set pagetitle = \"" + my_page_title + "\" , pagebody = \"" +
                        my_page_body + "\" where pageid = \"" + page_record + "\"";
                    database.applyQuery(query);
                    Response.Redirect("ListPages.aspx");
                }
            }
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            if (valid)
            {
                var db = new Page_db();
                Dictionary<String, String> page_record = db.FindPage(Int32.Parse(pageid));

                if (page_record.Count > 0)
                {
                    page_title.Text = page_record["pagetitle"];
                    page_body.Text = page_record["pagebody"];
                }
                else
                {
                    valid = false;
                }
            }

            if (!valid)
            {
                page.InnerHtml = "There was an error finding that page!.";
            }
        }
    }
}