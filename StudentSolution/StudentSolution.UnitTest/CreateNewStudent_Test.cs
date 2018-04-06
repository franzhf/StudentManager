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
            int iNumberOfStudent = students.count;
            Student szJhon = new Student()
            {
                Type: "High",
                Name: "Jhon",
                Gender: "Male",
                TimeSpam: DateTime

            };
            students.Add(szJhon);
            string szResult = manager.Exists(szJhon.Name);
            Assert.AreEqual(iNumberOfStudent, szResult);
    }
}
