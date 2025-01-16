using System;
using System.Web.UI;

namespace ClassDemo
{
    public partial class MultiView : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0; // Set default view to View 1
            }
        }

        // Navigate to View 2
        protected void btnToView2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        // Navigate to View 1
        protected void btnToView1_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        // Navigate to View 3
        protected void btnToView3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 2;
        }

        // Navigate to View 2 from View 3
        protected void btnToView2From3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        // Event handler for active view changes (optional)
        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {
            // Example: Log the current view index (if needed)
            int currentIndex = MultiView1.ActiveViewIndex;
            Response.Write($"Active view changed to index: {currentIndex}");
        }
    }
}
