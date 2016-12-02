using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWeb.Client
{
   public partial class Site : System.Web.UI.MasterPage
   {
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void studentButton_Click(object sender, EventArgs e)
      {
         Response.Redirect("default.aspx");
      }

      protected void registrarButton_Click(object sender, EventArgs e)
      {
         Response.Redirect("registrar.aspx");
      }
   }
}