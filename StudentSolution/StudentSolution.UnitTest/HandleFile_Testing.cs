using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSolution.FileManagment;
using StudentSolution.Data;

namespace StudentSolution.UnitTest
{
    /// <summary>
    /// Summary description for HandleFile_Testing
    /// </summary>
    [TestClass]
    public class HandleFile_Testing
    {

        [TestMethod]
        public void Write_A_Student_in_CSVFile()
        {
            // managing the information in a CSV file
            IFileFactory fileFactory = new FileFactory();
            IHandleFile handleFile = fileFactory.GetFileType("CSV");
            string szPath = "inputTest.csv";
            Student oInputStudent = HelpfulData.CreateOneStudent(DateTime.Now);

            handleFile.Write(oInputStudent, szPath);
            IEnumerable<Student> oStudents = handleFile.Read(szPath);

            Student oOutputStudent = null;
            foreach (var i in oStudents)
                oOutputStudent = i;

            Assert.AreEqual(oOutputStudent.TimeStamp.ToLongDateString(), oInputStudent.TimeStamp.ToLongDateString());
        }


    }
}
