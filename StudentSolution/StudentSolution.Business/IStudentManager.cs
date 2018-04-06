using System;
using System.Collections;
using System.Collections.Generic;
using StudentSolution.Data;

namespace StudentSolution.Business
{
    public interface IStudentManager
    {
        List<Student> Students { get; set; }

        bool Exists(Student oStudent);
        
    }
}
