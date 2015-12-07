using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRegistration
{
    public class StudentList
    {
        public List<Student> mockStudentList = new List<Student>()
            {
                new Student("111-11-1212", "Bart", "Simpson", "Information Systems", "Full Time"),
                new Student("123-12-1234", "Maggie", "Simpson", "International Affairs", "Part Time"),
            };
    }
}
