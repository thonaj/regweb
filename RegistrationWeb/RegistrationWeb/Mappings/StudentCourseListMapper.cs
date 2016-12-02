using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.Models;
using RegistrationWeb.ServiceReference1;
namespace RegistrationWeb.Mappings
{
   public class StudentCourseListMapper
   {
      public StudentCourseListDAO mapToStudentCourseListDAO(StudentCourseListDTO scl)
      {
         var sc = new StudentCourseListDAO();
         sc.courseID = scl.courseID;
         sc.StudentCourseID = scl.AppId;         
         sc.studentID = scl.StudentID;
         sc.active = scl.Active;
         
         return sc;
      }
      public StudentCourseListDAO mapToStudentCourseListDAO(StudentCourseListDTO scl, StudentCourseListDAO sc)
      {
         
         sc.courseID = scl.courseID;
         sc.StudentCourseID = scl.AppId;
         sc.studentID = scl.StudentID;
         sc.active = scl.Active;

         return sc;
      }

      public StudentCourseListDTO mapToStudentCourseListDTO(StudentCourseListDAO scl)
      {
         var sc = new StudentCourseListDTO();
         sc.AppId = scl.StudentCourseID;
         sc.courseID = scl.courseID;
         sc.Name = scl.Course.courseName + "_" + scl.Student.firstName + "_" + scl.Student.lastName;
         sc.StudentID = scl.studentID;
         sc.Active = scl.active;
         return sc;
      }
      public StudentCourseListDTO mapToStudentCourseListDTO(StudentCourseListDAO scl, StudentCourseListDTO sc)
      {
         
         sc.AppId = scl.StudentCourseID;
         sc.courseID = scl.courseID;
         sc.Name = scl.Course.courseName + "_" + scl.Student.firstName + "_" + scl.Student.lastName;
         sc.StudentID = scl.studentID;
         sc.Active = scl.active;
         return sc;
      }
   }
}
