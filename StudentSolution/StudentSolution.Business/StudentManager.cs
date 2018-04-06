using System;
using System.Collections.Generic;
using System.Text;
using StudentSolution.Data;

namespace StudentSolution.Business
{
    public class StudentManager : IStudentManager
    {
        List<Student> _students;

        public StudentManager()
        {
            _students = new List<Student>();
        }
        public List<Student> Students { get => _students; set => _students = value; }

        public bool Exists(Student oStudent)
        {
           return _students.Exists(s => s.Equals(oStudent));
        }
    }
}
