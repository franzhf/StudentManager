using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSolution.Data
{
    public interface IStudentRepository
    {
     
        void Add(Student oStudent);

        void Remove(Student oStudent);

        IEnumerable<Student> GetContext();
        //IEnumerable<Student> Search(Student oStudent);

        
    }
}
