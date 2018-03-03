using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWebAPI.Controller
{
    public class StudentController : ApiController
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
       // [Route("api/student/names")]
        public IEnumerable<string> GetStudent()
        {
            return new string[] { "Ram", "Rahim" };
        }
        public List<Student> Post(Student student)
        {
            List<Student> lstStudent = new List<Student>();
            lstStudent.Add(student);
            return lstStudent;
        }
    }
}
