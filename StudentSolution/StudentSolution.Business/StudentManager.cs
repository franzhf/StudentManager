using System;
using System.Collections.Generic;
using System.Text;
using StudentSolution.Data;
using StudentSolution.FileManagment;
using System.Linq;
namespace StudentSolution.Business
{
    public class StudentManager : IStudentManager
    {
        IStudentRepository _oRepository;
        IHandleFile _oHandleFile;

        public StudentManager(IStudentRepository oRepository, IHandleFile oHandleFile)
        {
            _oRepository = oRepository;
            _oHandleFile = oHandleFile;

        }

        public bool Compare(Student a, Student b)
        {
            // a == b are equals if any property value matching
            // a.Name = ana , b.Name = ana :  true
            // a.Name = ana , b.Name = ana ; a.Type = kinder , b.Type = High :  false
            if (SoftComparison(a, b) == true)
                return true;
            if (MediumComparison(a, b) == true)
                return true;
            if (HardComparison(a, b) == true)
                return true;
            return false;

        }

        /// <summary>
        /// this.Name = ana  , b.Name = ana
        /// b.type = None
        /// b.gender = null
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private bool SoftComparison(Student a, Student b)
        {
            if (b.Name != null && b.Gender == null && b.Type == StudentType.None)
                return b.Name.ToLower() == a.Name.ToLower();
            if (b.Name == null && b.Gender != null && b.Type == StudentType.None)
                return b.Gender.ToLower() == a.Gender.ToLower();
            if (b.Name == null && b.Gender == null && b.Type != StudentType.None)
                return b.Type.ToString().ToLower() == a.Type.ToString().ToLower();

            return false;
        }

        private bool MediumComparison(Student a, Student b)
        {
            if (b.Name != null && b.Gender != null && b.Type == StudentType.None)
                return b.Name.ToLower() == a.Name.ToLower() && b.Gender.ToLower() == a.Gender.ToLower();
            if (b.Name == null && b.Gender != null && b.Type != StudentType.None)
                return b.Gender.ToLower() == a.Gender.ToLower() && b.Type.ToString().ToLower() == a.Type.ToString().ToLower();
            if (b.Name != null && b.Gender == null && b.Type != StudentType.None)
                return b.Type.ToString().ToLower() == a.Type.ToString().ToLower() && b.Name.ToLower() == a.Name.ToLower();
            return false;
        }

        private bool HardComparison(Student a, Student b)
        {
            if (b.Name != null && b.Gender != null && b.Type != StudentType.None)
                return b.Name.ToLower() == a.Name.ToLower() && b.Gender.ToLower() == a.Gender.ToLower() && b.Type.ToString().ToLower() == a.Type.ToString().ToLower();
            return false;
        }

       public IEnumerable<Student> Search(string szWhere)
       {
           Student oStudentInput = SearchHelper.MappingStrToStudent(szWhere);
           // linq
           var oStudents = from s in _oRepository.GetContext()
                           where Compare(s, oStudentInput)
                           select s;

           return oStudents;
       }

       public void Sync()
       {
            foreach (var oStudent in _oRepository.GetContext())
            {
                if (oStudent.IsSync == false)
                    this._oHandleFile.Write(oStudent);
            }
       }

       public void Save (List<Student> students)
       {
            foreach (var oStudent in students)
                Save(oStudent);
       }

        public void Save(Student student)
        {
            this._oRepository.Add(student);
        }
    }
}
