using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentSolution.UnitTest
{
    [TestClass]
    public class EstudentRepository_Test
    {
        [TestMethod]
        public void Add_New_Student()
        {
            List<Student> oStudents = new List<Student>();
            Student oInputStudent = helper.Createone();
            IStudentRespository oRepo = new StudentRespository(context);
            oRepo.Add(oInputStudent);

            Student oExpectResult = oRepo.Search(oInputStudent.Name);

            Assert.IsNotNull(oExpectResult);
        }
    }
}
