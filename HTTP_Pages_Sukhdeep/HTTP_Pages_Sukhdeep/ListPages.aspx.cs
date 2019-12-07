using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_Pages_Sukhdeep
{
    public partial class ListPages : System.Web.UI.Page
    {
        //REFERENCED CODE FROM CHRISTINE BITTLE,
        //*https://github.com/christinebittle/crud_essentials*/, ON DEC 3 ,2019 FOR FINAL PROJECT FOR SCHOOL
        protected void Page_Load(object sender, EventArgs e)
        {
            pages_result.InnerHtml = "";
            //HERE I AM SETTING QUERY
            string query = "select * from pageshttp";
           
            
            // CREATING OBJECT OF PAGE DB CLASS
            var db = new Page_db();
            List<Dictionary<String, String>> rs = db.List_Query(query);
            foreach (Dictionary<String, String> row in rs)
            {
                pages_result.InnerHtml += "<div class=\"listitem\">";

                //DISPLAYING PAGES TITLES 

                string pagetitle = row["pagetitle"];
                pages_result.InnerHtml += "<div class=\"col3\">" + pagetitle + "</div>";

                //CREATING,DISPLAYING EDIT BUTTON AND LINKING TO EDIT PAGE WHERE USER CAN EDIT TITLE AND BODY 
                pages_result.InnerHtml += "<div class=\"col3\"><a href=\"EditPages.aspx?pageid=" + row["pageid"] + "\"> <button type=\"button\">Edit</button></a></div>";
                //CREATING DELETE BUTTON WHICH LINKS TO NEW CLASS WHICH HAS  DELETE FUNCTIONALITY
                pages_result.InnerHtml += "<div class=\"col3last\"><a href=\"DeletePages.aspx?pageid=" + row["pageid"] + "\"> <button type=\"button\">Delete</button></a></div>";

                pages_result.InnerHtml += "</div>";
            }

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }
    }
}