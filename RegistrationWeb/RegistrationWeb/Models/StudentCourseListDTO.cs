using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.Logic.Interfaces;

namespace RegistrationWeb.Models
{
   public class StudentCourseListDTO : RegistrationThing
   {
      private string _Name = default(string);
      public int StudentID { get; set; }
      public int courseID { get; set; }
      public bool Active { get; set; }
      public override string Name
      {
         get
         {
            return _Name;
         }
         set
         {
            IsNull(ref _Name, value);
         }
      }
      public StudentCourseListDTO() : base()
      {
      }

      internal override StudentCourseListDTO Create<StudentCourseListDTO>()
      {
         return new StudentCourseListDTO();
      }

      private void IsNull(ref string data, string value)
      {
         if (string.IsNullOrWhiteSpace(value))
         {
            return;
         }
         data = value;

      }
   }
}
