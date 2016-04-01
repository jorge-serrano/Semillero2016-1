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

namespace Ecommerce
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMesagge.Visible = false;
        }

        protected void ButSubmit_Click(object sender, EventArgs e)
        {
            string UserName = TextUser.Text;

            using (SqlConnection connection = new SqlConnection(@"Data Source = ADMINISTRATOR1\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = Ecommerce"))
            {
                using (SqlCommand cmd = new SqlCommand("GetSingleUserEcommerce", connection))
                {

                    string aux = Function_String(TextPasword.Text);

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = UserName;
                    cmd.Parameters.Add("@passwordUser", SqlDbType.VarChar).Value = aux;
                    connection.Open();

                    try
                    {
                        SqlDataReader rdr = cmd.ExecuteReader(CommandBehavior.CloseConnection);



                        if (rdr.HasRows)
                        {
                            LblMesagge.Text = "Your Conecction was successful";
                        }
                        else
                        {
                            LblMesagge.Visible = true;
                            LblMesagge.Text = "Your username or password are incorrect";
                            Server.Transfer("Default.aspx", true);
                            // Response.Redirect("Default.apx");
                        }

                    }
                    catch (Exception)
                    {

                        LblMesagge.Text = "There was no response from the server , contact the administrator";
                        Server.Transfer("Default.aspx", true);
                        // Response.Redirect("Default.apx");
                    }

                    finally
                    {
                        connection.Close();

                    }
                }
            }


        }

        public string Function_String(string strkeyword)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(strkeyword);
            byte[] hash = md5.ComputeHash(inputBytes);
            LblMesagge.Visible = true;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }

            return sb.ToString();
        }
    }
}