using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using StudentSolution.Business;
using StudentSolution.Data;
namespace StudentSolution.UnitTest
{
    [TestClass]
    public class CreateNewStudent_Test
    {
        [TestMethod]
        public void CreateNewStudent_CheckIfExists()
        {

            IStudentManager manager = new StudentManager();
            Student oJhon = CreateOneStudent();
            manager.Students.Add(oJhon);
            bool szResult = manager.Exists(oJhon);
            Assert.IsTrue(szResult);
        }

        [TestMethod]
        public void CreateNewStudent_SaveIt_CSV_File()
        {
            IStudentManager manager = new StudentManager();
            Student oJhon = CreateOneStudent();

            
        }

        [TestMethod]
        public void Save()
        {

        }

        private Student CreateOneStudent()
        {
            Student szJhon = new Student
            {
                Type = StudentType.High,
                Name = "Jhon",
                Gender = "Male",
                TimeSpam = DateTime.Now
            };
            return szJhon;
        }

    }
}
