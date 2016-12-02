using RegistrationWeb.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWeb.Client
{
   public partial class viewstudentschedule : System.Web.UI.Page
   {
      private GridView grid;
      private DataService data = new DataService();
      protected void Page_Load(object sender, EventArgs e)
      {
         if (!IsPostBack)
         {
            grid = Session.Contents[0] as GridView;
            studentname.Text = "Student :" + grid.SelectedRow.Cells[1].Text + " " + grid.SelectedRow.Cells[2].Text;
            showcourses();
         }

      }
      protected void showcourses()
      {
         courses.DataSource = data.listStudentSchedule(data.getStudents().Where(s => s.AppId == int.Parse(grid.SelectedRow.Cells[0].Text)).FirstOrDefault());
         courses.DataBind();
      }
   }
}