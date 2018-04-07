using System;

namespace StudentSolution.Data
{
    public enum StudentType
    {
        None, // avoid the automatic set up
        Kinder,
        Elementary,
        High,
        university
    }

    public class Student
    {
       
        public string Name { get; set; }

        public StudentType Type { get; set; }

        public string Gender { get; set; }

        public DateTime TimeSpam { get; set; }

        public void SetStudentType(string value)
        {
            StudentType oType = StudentType.High;

            if (value.ToLower() == StudentType.High.ToString().ToLower())
                oType = StudentType.High;
            else if (value.ToLower() == StudentType.Elementary.ToString().ToLower())
                oType = StudentType.Elementary;
            else if (value.ToLower() == StudentType.university.ToString().ToLower())
                oType = StudentType.university;
            else if (value.ToLower() == StudentType.Kinder.ToString().ToLower())
                oType = StudentType.Kinder;

            Type = oType;
        }
    }
}
