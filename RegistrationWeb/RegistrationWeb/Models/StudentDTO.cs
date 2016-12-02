using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.Logic.Interfaces;

namespace RegistrationWeb.Models
{
   public class StudentDTO : RegistrationThing
   {
      private string _Name = default(string);
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
      public string firstName { get; set; }
      public string middleName { get; set; }
      public string lastName { get; set; }
      public string major { get; set; }
      public bool Active { get; set; }
      public StudentDTO() : base()
      {
      }

      internal override StudentDTO Create<StudentDTO>()
      {
         return new StudentDTO();
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
