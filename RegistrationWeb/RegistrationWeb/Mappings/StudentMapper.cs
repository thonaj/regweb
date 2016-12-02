using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.Models;
using RegistrationWeb.ServiceReference1;
namespace RegistrationWeb.Mappings
{
   public class StudentMapper
   {
      public StudentDAO mapToStudentDAO(StudentDTO scl)
      {
         var s = new StudentDAO();
         s.firstName = scl.firstName;
         s.lastName = scl.lastName;
         s.major = scl.major;
         s.middleName = scl.middleName;
         s.studentID = scl.AppId;
         s.active = scl.Active;

         return s;
      }
      public StudentDAO mapToStudentDAO(StudentDTO scl, StudentDAO s)
      {

         s.firstName = scl.firstName;
         s.lastName = scl.lastName;
         s.major = scl.major;
         s.middleName = scl.middleName;
         s.studentID = scl.AppId;
         s.active = scl.Active;

         return s;
      }
      public StudentDTO mapToStudentDTO(StudentDAO st)
      {
         var s = new StudentDTO();
         s.AppId = st.studentID;
         s.firstName = st.firstName;
         s.lastName = st.lastName;
         s.major = st.major;
         s.middleName = st.middleName;
         s.Name = st.lastName + "_" + st.firstName;
         s.Active = st.active;
         return s;
      }
      public StudentDTO mapToStudentDTO(StudentDAO st, StudentDTO s)
      {
         
         s.AppId = st.studentID;
         s.firstName = st.firstName;
         s.lastName = st.lastName;
         s.major = st.major;
         s.middleName = st.middleName;
         s.Name = st.lastName + "_" + st.firstName;
         s.Active = st.active;
         return s;
      }
   }
}
