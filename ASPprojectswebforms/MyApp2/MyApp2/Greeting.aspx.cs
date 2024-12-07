using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyApp2
{
    public partial class Greeting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GreetUser(object sender, EventArgs e)
        {
            string name=txtName.Text;
            lblname.Text = "Good morming" + name;
        }
    }
}