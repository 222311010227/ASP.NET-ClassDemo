using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassDemo
{
    public partial class AD : System.Web.UI.Page
    {
        protected Label Label1;
        protected FileUpload FileUpload1;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string filename = FileUpload1.FileName; // Corrected property name
                    string filePath = Server.MapPath("D:\\6th SEM\\ASP.Net\\ClassDemo\\ClassDemo\\Files\\") + filename; // Ensured correct path
                    FileUpload1.SaveAs(filePath); // Corrected variable name
                    Label1.Text = "File Uploaded!";
                }
                catch (Exception ex)
                {
                    Label1.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                Label1.Text = "No file selected.";
            }
        }
    }
}
