using RegistrationWeb.Logic;
using RegistrationWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RegistrationWeb.Client
{
   public partial class addcourse : System.Web.UI.Page
   {
      private DataService data = new DataService();
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void addcoursebutton_Click(object sender, EventArgs e)
      {
         CourseDTO course = new CourseDTO();
         course.Active = true;
         course.courseCapacity = int.Parse(capacitybox.Text);
         course.courseCredits = int.Parse(credtext.Text);
         course.courseDepartment = deptbox.Text;
         course.courseProfessor = profbox.Text;
         course.Name = namebox.Text;
         course.startTime = new TimeSpan(int.Parse(start1box.Text), int.Parse(start2box.Text), int.Parse(start3box.Text));
         course.endTime = new TimeSpan(int.Parse(end1box.Text), int.Parse(end2box.Text), int.Parse(end3box.Text));
         data.addCourse(course);
         Response.Redirect("registrar.aspx");
      }
   }
}