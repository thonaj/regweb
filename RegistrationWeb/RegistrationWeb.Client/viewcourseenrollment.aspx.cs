using RegistrationWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWeb.Client
{
   public partial class viewcourseenrollment : System.Web.UI.Page
   {
      private GridView grid;
      private DataService data = new DataService();
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            grid = Session.Contents[1] as GridView;
            courseName.Text = "Course :" + grid.SelectedRow.Cells[1].Text;
            showstudents();
         }

      }
      protected void showstudents()
      {
         enrolledstudents.DataSource = data.listEnrolledStudents(data.getCourses().Where(s => s.AppId == int.Parse(grid.SelectedRow.Cells[0].Text)).FirstOrDefault());
         enrolledstudents.DataBind();
      }
   }
}