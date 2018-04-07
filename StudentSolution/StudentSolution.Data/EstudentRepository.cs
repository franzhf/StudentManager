using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StudentSolution.Data
{
    public class EstudentRepository : IStudentRepository
    {
        
        private List<Student> _oContext;


        public EstudentRepository(List<Student> oStudents)
        {
            _oContext = oStudents;
        }
                
        public void Add(Student oStudent)
        {
            _oContext.Add(oStudent);
        }

        public IEnumerable<Student> GetContext()
        {
            return _oContext;
        }

        public void Remove(Student oStudent)
        {
            _oContext.Remove(oStudent);
        }


        /*public IEnumerable<Student> Search(string szWhere)
        {   //e.g name=ana type=kinder
           
        }*/

        /*public IEnumerable<Student> Search(Student oStudent)
        {
            Student oStudentInput = SearchHelper.MappingStrToStudent(szWhere);
            // linq
            var oStudents = from s in _oContext
                            where s.Compare(oStudentInput)
                            select s;

            return oStudents;
        }*/
    }
}
