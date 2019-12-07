using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;
using MySql.Data.MySqlClient;
using System.Diagnostics;
//REFERENCED CODE FROM CHRISTINE BITTLE,
//*https://github.com/christinebittle/crud_essentials*/, ON DEC 3 ,2019 FOR FINAL PROJECT FOR SCHOOL
namespace HTTP_Pages_Sukhdeep
{
    public class Page_db
    {
        //this is my page db class to initialize connection with the database
        private static string User { get { return "root"; } }
        private static string Password { get { return "root"; } }
        private static string Database { get { return "mypages"; } }
        private static string Server { get { return "localhost"; } }
        private static string Port { get { return "3306"; } }

     
        private static string ConnectionString
        {
            get
            {
                return "server = " + Server
                    + "; user = " + User
                    + "; database = " + Database
                    + "; port = " + Port
                    + "; password = " + Password;
            }
        }

   
        public List<Dictionary<String, String>> List_Query(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);

             
            List<Dictionary<String, String>> ResultSet = new List<Dictionary<String, String>>();

            
            try
            {
                Debug.WriteLine("Connection Initialized...");
                Debug.WriteLine("Attempting to execute query " + query);
                //open the db connection
                Connect.Open();
                //give the connection a query
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                //grab the result set
                MySqlDataReader resultset = cmd.ExecuteReader();


                //for every row in the result set
                while (resultset.Read())
                {
                    Dictionary<String, String> Row = new Dictionary<String, String>();
                    //for every column in the row
                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Row.Add(resultset.GetName(i), resultset.GetString(i));

                    }

                    ResultSet.Add(Row);
                }//end row
                resultset.Close();


            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the List_Query method!");
                Debug.WriteLine(ex.ToString());

            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return ResultSet;

        }
        //MY FUNCTON TO PERFORM OPERATION ON QUERY WHICH OPEN THE CONNECTION,
        //CONNECT WITH QUERY AND PROVIDE RESULT SET
        public void applyQuery(string query)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Connect.Open();
            Debug.WriteLine(query);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            MySqlDataReader resultset = cmd.ExecuteReader();
        }
            
        public Dictionary<String, String> FindPage(int id)
        {
            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            Dictionary<String, String> page = new Dictionary<String, String>();
            //CODE SNIPPET TO FIND THE PAGE WITH PARTICULAR ID 
            try
            {
                string query = "select * from pageshttp where pageid = " + id;
                Debug.WriteLine("Connection Initialized...");
                Connect.Open();
                MySqlCommand cmd = new MySqlCommand(query, Connect);
                MySqlDataReader resultset = cmd.ExecuteReader();

                List<Dictionary<String, String>> Pages = new List<Dictionary<String, String>>();

                while (resultset.Read())
                {
                    Dictionary<String, String> Page = new Dictionary<String, String>();

                    for (int i = 0; i < resultset.FieldCount; i++)
                    {
                        Debug.WriteLine("Attempting to transfer data of " + resultset.GetName(i));
                        Debug.WriteLine("Attempting to transfer data of " + resultset.GetString(i));
                        Page.Add(resultset.GetName(i), resultset.GetString(i));

                    }
                    Pages.Add(Page);
                }

                page = Pages[0]; 

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the find Pages method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
            Debug.WriteLine("Database Connection Terminated.");

            return page;
        }
        public void AddPage(HTTPPage new_page)
        {
            //HERE IS INSERT QUERY TO ADD NEW PAGE 
            string query = "insert into pageshttp (pagetitle, pagebody) values ('{0}','{1}')";
            query = String.Format(query, new_page.GetTitle(), new_page.GetBody());

            MySqlConnection Connect = new MySqlConnection(ConnectionString);
            MySqlCommand cmd = new MySqlCommand(query, Connect);
            //EXCEPTION DESCRIBED FOR MODIFYING THE ERROR TO SHOW TO USER 
            try
            {
                Connect.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Something went wrong in the AddPage Method!");
                Debug.WriteLine(ex.ToString());
            }

            Connect.Close();
        }
    }
}
