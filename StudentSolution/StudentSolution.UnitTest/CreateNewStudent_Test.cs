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
        public void CreateNewStudent_CheckByName()
        {

            IStudentManager manager = new StudentManager();
            Student szJhon = new Student
            {
                Type = "High",
                Name = "Jhon",
                Gender = "Male",
                TimeSpam = DateTime.Now
            };
            manager.Students.Add(szJhon);
            bool szResult = manager.Exists(szJhon);
            Assert.IsTrue(szResult);
        }
    }
}
