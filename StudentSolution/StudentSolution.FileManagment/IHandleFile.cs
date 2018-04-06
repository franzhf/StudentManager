using System;
using StudentSolution.Data;
using System.Collections;
using System.Collections.Generic;

namespace StudentSolution.FileManagment
{
    public interface IHandleFile
    {
        void Write(Student oStudent,string szPath);
        IEnumerable<Student> Read(string szPath);

    }
}
