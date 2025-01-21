using System;
using System.Web.UI;
using System.Data.SqlClient;

namespace ClassDemo
{
    public partial class Registration : Page
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\6th SEM\\ASP.Net\\ClassDemo\\ClassDemo\\App_Data\\Database1.mdf\";Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string sem = txtSem.Text;
            string branch = txtBranch.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password != confirmPassword)
            {
                Response.Write("<script>alert('Passwords do not match. Please try again.');</script>");
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO Register (Name, Sem, Branch, Email, Password) VALUES (@Name, @Sem, @Branch, @Email, @Password)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@Sem", sem);
                cmd.Parameters.AddWithValue("@Branch", branch);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);

                cmd.ExecuteNonQuery();
                Response.Write("<script>alert('Registration Successful!');</script>");
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('An error occurred: {ex.Message}');</script>");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
