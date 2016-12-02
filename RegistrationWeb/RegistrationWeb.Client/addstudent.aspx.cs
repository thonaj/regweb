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
   public partial class addstudent : System.Web.UI.Page
   {
      private DataService data = new DataService();
      protected void Page_Load(object sender, EventArgs e)
      {

      }

      protected void addstudentbutton_Click(object sender, EventArgs e)
      {
         StudentDTO student = new StudentDTO();
         student.Active = true;
         student.firstName = firstbox.Text;
         student.middleName = middlebox.Text;
         student.lastName = lastbox.Text;
         student.major = majorbox.Text;
         student.Name = student.firstName + " " + student.lastName;
         data.addStudent(student);
         Response.Redirect("registrar.aspx");
      }
   }
}