using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {

            }
        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {           
            lblMessage.Text = "<h2>hello " + txtName.Text + "!</h2>";
            lblMessage.Visible = true;

            // Here's where you do stuff.
        }
    }
}