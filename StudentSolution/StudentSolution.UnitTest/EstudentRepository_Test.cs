using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSolution.Data;
using System.Collections.Generic;

namespace StudentSolution.UnitTest
{
    [TestClass]
    public class EstudentRepository_Test
    {
        [TestMethod]
        public void Add_New_Student()
        {
            List<Student> oContext = new List<Student>();
            Student oInputStudent = HelpfulData.CreateOneStudent(DateTime.Now);
            IStudentRepository oRepo = new EstudentRepository(oContext);
            oRepo.Add(oInputStudent);

            // Commandline   :   "name=jhon gender=M"
            string szInputCommandLine = "name=jhon gender=M";
            IEnumerable<Student> oResult = oRepo.Search(szInputCommandLine);
            Student oExpectResult = null;

            //should be match one
            foreach (var s in oResult)
                oExpectResult = s;
            Assert.IsNotNull(oExpectResult);
            Assert.AreEqual(oInputStudent.Name, oExpectResult.Name);
            Assert.AreEqual(oInputStudent.Gender, oExpectResult.Gender);
        }
    }
}
