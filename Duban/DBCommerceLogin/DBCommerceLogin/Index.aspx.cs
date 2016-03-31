using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBCommerceLogin
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection url = new SqlConnection();
                url.ConnectionString = @"Data Source=YUXI\SQLEXPRESS;Initial Catalog=ECommerce;Integrated Security=True";
                url.Open();
                SqlCommand GetUser = new SqlCommand("ValidateUser", url);
                GetUser.CommandType = CommandType.StoredProcedure;
                GetUser.Parameters.AddWithValue("@userName", txtUser.Text.Trim());
                GetUser.Parameters.AddWithValue("@keyWord", txtPassWord.Text.Trim());
                SqlDataReader reader = GetUser.ExecuteReader();
                if (reader.Read())
                {

                    Response.Redirect("WelcomeEC.aspx");
                   
                }
                else
                {
                    //Response.Write("User no exists");
                    Label1.Visible = true;
                    Label1.Text = "User doesn´t exist, please check your account";
                    txtUser.Text = "";


                }
            }
            catch (Exception m)
            {

                Label2.Text = m.Message;
            }
            

        }
    }
}