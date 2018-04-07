using System;
using StudentSolution.Data;
using System.Collections;
using System.Collections.Generic;

namespace StudentSolution.FileManagment
{
    public interface IHandleFile
    {
        string Path { get; set; }
        void Write(Student oStudent);
        List<Student> Read();

        List<Student> Read(string szPath);

    }
}
