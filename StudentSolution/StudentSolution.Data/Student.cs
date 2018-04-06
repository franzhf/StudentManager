using System;

namespace StudentSolution.Data
{
    public enum StudentType
    {
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


    }
}
