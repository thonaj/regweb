using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RegistrationWeb.Logic;

namespace RegistrationWeb.Client
{
   public partial class registrar : System.Web.UI.Page
   {
      private DataService data = new DataService();

      protected void Page_Load(object sender, EventArgs e)
      {

         if (!IsPostBack)
         {
            getStudents();
            getCourses();
            getStudentCourseList();
            getstudentsintogrid();
            getcoursesintocoursegrid();
            fillsclgrid();
         }
         if(IsPostBack)
         {
            getstudentsintogrid();
         }

      }

      

      private void getStudents()
      {
         studentlist.Items.Clear();
         foreach (var item in data.getStudents())
         {
            studentlist.Items.Add(item.firstName.ToUpper() + " " + item.lastName.ToUpper() + " " + item.major.ToUpper());

         }

      }
      private void getstudentsintogrid()
      {
         
         grid.DataSource = data.getStudents();
         grid.DataBind();

      }
      private void getCourses()
      {
         courselist.Items.Clear();
         foreach (var item in data.getCourses())
         {
            courselist.Items.Add(item.Name.ToUpper() + " " + item.courseDepartment.ToUpper() + " " + item.startTime + "-" + item.endTime + " " + item.currentEnrollment + "/" + item.courseCapacity);
         }
      }
      private void getStudentCourseList()
      {
         studentcourselist.Items.Clear();
         foreach (var item in data.getStudentCourseList())
         {
            studentcourselist.Items.Add(item.Name.ToUpper());
         }
      }

      protected void deleteStudentButton_Click(object sender, EventArgs e)
      {
         data.deleteStudent(data.getStudents().Where(s => s.AppId == int.Parse(grid.SelectedRow.Cells[0].Text)).FirstOrDefault());
         Response.Redirect(Request.RawUrl);
      }

      protected void deleteCourseButton_Click(object sender, EventArgs e)
      {
         data.deleteCourse(data.getCourses().Where(s => s.AppId == int.Parse(coursegrid.SelectedRow.Cells[0].Text)).FirstOrDefault());
         Response.Redirect(Request.RawUrl);
      }

      protected void unregisterCourse_Click(object sender, EventArgs e)
      {
         var temp= data.getStudentCourseList().Where(s => s.StudentID == int.Parse(sclgrid.SelectedRow.Cells[2].Text) && s.courseID == int.Parse(sclgrid.SelectedRow.Cells[3].Text)).FirstOrDefault();
         data.deletestudentcourseenrollment(temp);
         Response.Redirect(Request.RawUrl);
      }

      protected void viewStudentSchedule_Click(object sender, EventArgs e)
      {
         
         Response.Redirect("viewstudentschedule.aspx");
      }

      protected void viewCourseEnrollment_Click(object sender, EventArgs e)
      {
         Response.Redirect("viewcourseenrollment.aspx");
      }

      protected void grid_RowDataBound(object sender, GridViewRowEventArgs e)
      {
         //if (e.Row.RowType == DataControlRowType.DataRow)
         //   e.Row.Attributes.Add("OnMouseOver", "this.style.cursor = 'hand';");

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
      protected void setselectedindex(int index)
      {
         grid.SelectedIndex = index;
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

      protected void coursegrid_RowDataBound(object sender, GridViewRowEventArgs e)
      {

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

      protected void sclgrid_RowDataBound(object sender, GridViewRowEventArgs e)
      {

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
      protected void updateSessionContents()
      {
         Session.Contents.RemoveAll();
         Session.Contents.Add("grid", grid);
         Session.Contents.Add("coursegrid", coursegrid);
         Session.Contents.Add("sclgrid", sclgrid);
      }
      protected void fillsclgrid()
      {
         sclgrid.DataSource = data.getStudentCourseList();
         sclgrid.DataBind();
      }

      protected void addcoursebutton_Click(object sender, EventArgs e)
      {
         Response.Redirect("addcourse.aspx");

      }

      protected void addstudentbutton_Click(object sender, EventArgs e)
      {
         Response.Redirect("addstudent.aspx");
      }

      protected void modifycoursetime_Click(object sender, EventArgs e)
      {
         Response.Redirect("modifycoursetime.aspx");
      }

      protected void modifycoursecapacity_Click(object sender, EventArgs e)
      {
         Response.Redirect("modifycoursecapacity.aspx");
      }
   }
}