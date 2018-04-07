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

        public char Gender { get; set; }

        public DateTime TimeSpam { get; set; }


    }
}
