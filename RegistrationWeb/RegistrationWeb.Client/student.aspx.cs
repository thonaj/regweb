using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistrationWeb.Logic;
using RegistrationWeb.Models;

namespace RegistrationWeb.Client
{
   public partial class student : System.Web.UI.Page
   {
      private DataService data = new DataService();
      private GridView oldgrid;
      private List<string> cart = new List<string>();
      
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            oldgrid = Session.Contents[0] as GridView;            
            getstudentsintogrid();
            getcoursesintocoursegrid();
            fillsclgrid();
            updateSessionContents();
            fillcart();
            grid.SelectRow(0);            
         }         
         if(IsPostBack)
         {
            fillcart();
         }
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
         Session.Contents.Add("grid", grid);
         Session.Contents.Add("coursegrid", coursegrid);
         Session.Contents.Add("sclgrid", sclgrid);
         
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
      private void getstudentsintogrid()
      {         
         grid.DataSource = data.getStudents().Where(s => s.AppId==int.Parse(oldgrid.SelectedRow.Cells[0].Text));
         grid.DataBind();
      }

      protected void registerbutton_Click(object sender, EventArgs e)
      {
         StudentCourseListDTO scl = new StudentCourseListDTO();
         StudentDTO student = data.getStudents().Where(s => s.AppId == int.Parse(grid.SelectedRow.Cells[0].Text)).FirstOrDefault();
         CourseDTO course = data.getCourses().Where(c => c.AppId == int.Parse(coursegrid.SelectedRow.Cells[0].Text)).FirstOrDefault();
         scl.Active = true;
         scl.courseID = course.AppId;
         scl.Name =course.Name + "_" +student.firstName + "_" + student.lastName  ;
         scl.StudentID = student.AppId;
         
         data.registerCourse(scl);
         Response.Redirect(Request.RawUrl);
      }

      protected void dropbutton_Click(object sender, EventArgs e)
      {
         var temp = data.getStudentCourseList().Where(s => s.StudentID == int.Parse(sclgrid.SelectedRow.Cells[2].Text) && s.courseID == int.Parse(sclgrid.SelectedRow.Cells[3].Text)).FirstOrDefault();
         data.deletestudentcourseenrollment(temp);
         Response.Redirect(Request.RawUrl);
      }

      protected void sclgrid_RowCreated(object sender, GridViewRowEventArgs e)
      {
         if (e.Row.RowType == DataControlRowType.DataRow)
         {
            e.Row.Attributes["onmouseover"] = "this.style.cursor='pointer';this.style.textDecoration='underline';";
            e.Row.Attributes["onmouseout"] = "this.style.textDecoration='none';";
            e.Row.ToolTip = "Click to select row";
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackEventReference(sclgrid, "Select$" + e.Row.RowIndex));
         }
      }

      protected void sclgrid_SelectedIndexChanged(object sender, EventArgs e)
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
      protected void fillsclgrid()
      {
         sclgrid.DataSource = data.getStudentCourseList().Where(s => s.StudentID==int.Parse(oldgrid.SelectedRow.Cells[0].Text));
         sclgrid.DataBind();
      }

      protected void addtocartbutton_Click(object sender, EventArgs e)
      {
         cart.Add(coursegrid.SelectedRow.Cells[1].Text + " " + coursegrid.SelectedRow.Cells[2].Text);
         cartlist.DataBind();
         
         Response.Redirect(Request.RawUrl);

      }
      protected void fillcart()
      {
         cartlist.DataSource = cart;
         cartlist.DataBind();
         //foreach (var item in cart)
         //{
         //   cartlist.Items.Add(item);

         //}

      }




   }
}