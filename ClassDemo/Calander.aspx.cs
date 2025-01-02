using System;

namespace ClassDemo
{
    public partial class Calander : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = "Selected Date: " + Calendar1.SelectedDate.ToShortDateString();
        }
    }
}
