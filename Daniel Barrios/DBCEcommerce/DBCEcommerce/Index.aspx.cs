using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web.Security;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using System.Drawing;

namespace DBCEcommerce
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LoginInButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=UNIV;Initial Catalog=ECommerce;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand("GetSingle_UserPerson", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name.Text.Trim());
                    cmd.Parameters.AddWithValue("@keyword", GetHash(keyword.Text.Trim()));
                    con.Open();
                    cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Label1.ForeColor = Color.Green;
                        Label1.Text = "Your login was Successful";
                    }
                    else
                    {
                        Label1.ForeColor = Color.Red;
                        Label1.Text = "Your Password is wrong";
                    }
                    
                }
            }


        }
        public string GetHash(string text)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(text);
            byte[] hash = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();

        }
    }
}