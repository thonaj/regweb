using RegistrationWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWeb.Client
{
   public partial class modifycoursecapacity : System.Web.UI.Page
   {
      private DataService data = new DataService();
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)

         {
            
            getcoursesintocoursegrid();
            
         }
      }

      protected void changecapacitybutton_Click(object sender, EventArgs e)
      {
         int capacity = int.Parse(capacitytextbox.Text);
         var course = data.getCourses().Where(c => c.AppId == int.Parse(coursegrid.SelectedRow.Cells[0].Text)).FirstOrDefault();
         data.modifyCourseCapacity(course, capacity);
         Response.Redirect(Request.RawUrl);
      }

      protected void coursegrid_RowCreated(object sender, GridViewRowEventArgs e)
      {
         if (e.Row.RowType == DataControlRowType.DataRow)
         {
            e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
            e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
            e.Row.ToolTip = "Click to select row";
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(coursegrid, "Select$" + e.Row.RowIndex));
         }
      }

      protected void coursegrid_SelectedIndexChanged(object sender, EventArgs e)
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
      private void getcoursesintocoursegrid()
      {
         coursegrid.DataSource = data.getCourses();
         coursegrid.DataBind();
      }
      protected void updateSessionContents()
      {
         Session.Contents.RemoveAll();
         //Session.Contents.Add("grid", grid);
         Session.Contents.Add("coursegrid", coursegrid);
         //Session.Contents.Add("sclgrid", sclgrid);
      }
   }
}