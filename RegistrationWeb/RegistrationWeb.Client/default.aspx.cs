using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistrationWeb.Logic;


namespace RegistrationWeb.Client
{
   public partial class _default : System.Web.UI.Page
   {
      private DataService data = new DataService();
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)

         {
            
            getstudentsintogrid();
         }

      }
      

      protected void grid_RowCreated(object sender, GridViewRowEventArgs e)
      {
         if (e.Row.RowType == DataControlRowType.DataRow)
         {
            e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
            e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
            e.Row.ToolTip = "Click to select row";
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(grid, "Select$" + e.Row.RowIndex));
         }
      }

      protected void grid_SelectedIndexChanged(object sender, EventArgs e)
      {
         var s = sender as GridView;
         foreach (var item in s.Rows)
         {
            GridViewRow itm = item as GridViewRow;
            itm.BackColor = System.Drawing.Color.White;
         }
         s.SelectedRow.BackColor = System.Drawing.Color.Gray;
         updateSessionContents();
      }
      protected void updateSessionContents()
      {
         Session.Contents.RemoveAll();
         
         Session.Contents.Add("grid", grid);

      }
      private void getstudentsintogrid()
      {

         grid.DataSource = data.getStudents();
         grid.DataBind();

      }

      protected void selectbutton_Click(object sender, EventArgs e)
      {
         Response.Redirect("student.aspx");
      }
   }
}