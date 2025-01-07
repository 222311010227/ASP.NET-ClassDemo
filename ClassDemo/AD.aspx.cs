using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClassDemo
{
    public partial class AD : Page
    {
        protected Label Label1;
        protected FileUpload FileUpload1;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Any initialization logic goes here
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                try
                {
                    string filename = FileUpload1.FileName; // Get the uploaded file name
                    string filePath = Server.MapPath("~/Files/") + filename; // Use relative path

                    // Save the file to the specified path
                    FileUpload1.SaveAs(filePath);

                    // Display a success message
                    Label1.Text = "File Uploaded Successfully!";
                }
                catch (Exception ex)
                {
                    // Display the error message
                    Label1.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                // Display a message when no file is selected
                Label1.Text = "No file selected.";
            }
        }
    }
}
