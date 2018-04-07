using System;
using System.Collections;
using System.Collections.Generic;
using StudentSolution.Data;

namespace StudentSolution.Business
{
    public interface IStudentManager
    {
        bool Compare(Student a, Student b);

        IEnumerable<Student> Search(string szWhere);

        void Sync();

        void Save(List<Student> oStudents);

        void Save(Student oStudent);

    }
}
