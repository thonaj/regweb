using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using RegistrationWeb;
using RegistrationWeb.Logic;

namespace RegistrationWeb.Test
{
    public class Class1
    {
      DataService ds = new DataService();
      [Fact]
      public void testGetStudents()
      {
         Assert.NotNull(ds.getCourses());
      }
    }
}
