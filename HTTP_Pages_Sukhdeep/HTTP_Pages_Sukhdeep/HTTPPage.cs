using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HTTP_Pages_Sukhdeep
{
    public class HTTPPage
    {
        private string PageTitle;
        private string PageBody;
        
        //THIS IS MY PAGE CLASS WHICH HAS GET AND SET METHODS FOR ACCESSNG LATER 
        
        public string GetTitle()
        {
            return PageTitle;
        }
        public string GetBody()
        {
            return PageBody;
        }
        

        
        public void SetTitle(string value)
        {
            PageTitle = value;
        }
        public void SetBody(string value)
        {
            PageBody = value;
        }
        
    }
}