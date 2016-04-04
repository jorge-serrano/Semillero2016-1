using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace DBCEcommerce.Modules
{
    public class Modulesp : IHttpModule
    {
        /// <summary>
        /// You will need to configure this module in the Web.config file of your
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpModule Members

        public void Dispose()
        {
            //clean-up code here.
        }

        public void Init(HttpApplication context)
        {
            // Below is an example of how you can handle LogRequest event and provide 
            // custom logging implementation for it
            context.LogRequest += new EventHandler(OnLogRequest);
        }

        #endregion


        public void OnLogRequest(Object source, EventArgs e)
        {
            //custom logging logic can go here
        }

        public string GetSingle_UserPerson(string name, string keyword)
        {
            using (SqlConnection con = new SqlConnection())
            {
                using (SqlCommand cmd = new SqlCommand("GetSingle_UserPerson", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
                    cmd.Parameters.Add("@keyword", SqlDbType.VarChar).Value = keyword;

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }

            return "YES";
        }
    }
}
