using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSolution.Data;
namespace StudentSolution.UnitTest
{
    public static class HelpfulData
    {
        public static Student CreateOneStudent(DateTime oTimeSpam)
        {
            Student szJhon = new Student
            {
                Type = StudentType.High,
                Name = "Jhon",
                Gender = "M",
                TimeSpam = oTimeSpam
            };
            return szJhon;
        }
    }
}
