using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistrationWeb.Models;
using RegistrationWeb.Mappings;
using RegistrationWeb.ServiceReference1;

namespace RegistrationWeb.Logic
{
   public class DataService
   {
      private ServiceReference1.RegistrationServiceClient rsc = new RegistrationServiceClient() ;
      private FactoryThing<StudentDTO> studentFactory = new FactoryThing<StudentDTO>();
      private FactoryThing<CourseDTO> courseFactory = new FactoryThing<CourseDTO>();
      private FactoryThing<StudentCourseListDTO> sclFactory = new FactoryThing<StudentCourseListDTO>();
     
      public List<StudentDTO> getStudents()
      {
         List<StudentDTO> students = new List<StudentDTO>();
         foreach (var item in rsc.getStudents())
         {
            var temp = studentFactory.Create();
            var s = new StudentMapper().mapToStudentDTO(item,temp);
            students.Add(s);
         }
         return students;
      }

      public List<CourseDTO> getCourses()
      {
         List<CourseDTO> courses = new List<CourseDTO>();
         foreach (var item in rsc.getCourses())
         {
            var temp = courseFactory.Create();
            var s = new CourseMapper().mapToCourseDTO(item, temp);
            courses.Add(s);
         }
         return courses;
      }

      public List<StudentCourseListDTO> getStudentCourseList()
      {
         List<StudentCourseListDTO> scl = new List<StudentCourseListDTO>();
         foreach (var item in rsc.getStudentCourseList())
         {
            var temp = sclFactory.Create();
            var s = new StudentCourseListMapper().mapToStudentCourseListDTO(item, temp);
            scl.Add(s);
         }
         return scl;
      }
      public List<CourseDTO> listStudentSchedule(StudentDTO student)
      {
         List<CourseDTO> list = new List<CourseDTO>();
         foreach (var item in rsc.listStudentSchedule(new StudentMapper().mapToStudentDAO(student)))
         {
            var createdcourse = courseFactory.Create();
            var mappedcourse = new CourseMapper().mapToCourseDTO(item, createdcourse);
            list.Add(mappedcourse);
         }
         return list;
      }
      public List<StudentDTO> listEnrolledStudents(CourseDTO course)
      {
         List<StudentDTO> list = new List<StudentDTO>();
         foreach (var item in rsc.listEnrolledStudents(new CourseMapper().mapToCourseDAO(course)))
         {
            var createdstudent = studentFactory.Create();
            var mappedstudent = new StudentMapper().mapToStudentDTO(item, createdstudent);
            list.Add(mappedstudent);
         }
         return list;
      }
      public bool deleteStudent(StudentDTO student)
      {
         return rsc.deleteStudent(new StudentMapper().mapToStudentDAO(student));
      }
      public bool deleteCourse(CourseDTO course)
      {
         return rsc.deleteCourse(new CourseMapper().mapToCourseDAO(course));
      }
      public bool deletestudentcourseenrollment(StudentCourseListDTO scl)
      {
         return rsc.deleteStudentCourseList(new StudentCourseListMapper().mapToStudentCourseListDAO(scl));
      }
      public bool addCourse(CourseDTO course)
      {
         return rsc.insertCourse(new CourseMapper().mapToCourseDAO(course));
      }
      public bool addStudent(StudentDTO student)
      {
         return rsc.insertStudent(new StudentMapper().mapToStudentDAO(student));
      }
      public bool modifyCourseTime(CourseDTO course, TimeSpan start, TimeSpan end)
      {
         return rsc.modifyCourseTime(new CourseMapper().mapToCourseDAO(course), start, end);
      }
      public bool modifyCourseCapacity(CourseDTO course, int capacity)
      {
         return rsc.modifyCourseCapacity(new CourseMapper().mapToCourseDAO(course), capacity);
      }
      public bool registerCourse(StudentCourseListDTO scl)
      {
         return rsc.insertStudentCourseList(new StudentCourseListMapper().mapToStudentCourseListDAO(scl));
      }
   }
}
