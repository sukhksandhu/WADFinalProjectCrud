using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTTP_Pages_Sukhdeep
{
    public partial class pagecontroller : System.Web.UI.UserControl
    {
        //REFERENCED CODE FROM CHRISTINE BITTLE,
        //*https://github.com/christinebittle/crud_essentials*/, ON DEC 3 ,2019 FOR FINAL PROJECT FOR SCHOOL
        protected void Page_Load(object sender, EventArgs e)
        {
            Page_db db = new Page_db();
            ListMyPages(db);
        }
        //THIS CLASS IS USED IN MASTER FILE TO USE THE CODE FOR LINKS  
        protected void ListMyPages(Page_db db)
        {
            string query = "select * from pageshttp";

            List<Dictionary<String, String>> rs = db.List_Query(query);

            my_navigation.InnerHtml += "<ul class=\"main-menu\">";
            foreach (Dictionary<String, String> row in rs)
            {
                //LINKING TO VIEW PAGES FILE TO DISPLAY WHOLE PAGE 
                my_navigation.InnerHtml += "<li><a href=\"ViewPages.aspx?pageid=" + row["pageid"] + "\">" + row["pagetitle"] + "</a></li>";
               


            }
            my_navigation.InnerHtml += "</ul>";
            //HERE I AM CREATING BUTTON TO BACK TO HOME PAGE 
            my_navigation.InnerHtml += "<div><a href=\"ListPages.aspx" + "\"> <button id=\"backbutton\" type=\"button\">Back</button></a></div>";

            
        }

      
    }
}