using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StudentSolution.UnitTest
{
    /// <summary>
    /// Summary description for HandleFile_Testing
    /// </summary>
    [TestClass]
    public class HandleFile_Testing
    {
        public HandleFile_Testing()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        [TestMethod]
        public void Write_A_Student_in_CSVFile()
        {
            // I want to manage the information in a CSV file
            IFileFactory fileFactory = new FileFactory();
            IHandleFile = fileFactory.GetFileType("CSV");

            string szPath = "inputTest.csv";
            IHandleFile.Write(oNewStudent, szPath);
            IEnumerable<Student> oStudents = IHandleFile.Read(szPath);

            var oReadStudent = null;
            if (oStudents.Count > 0)
                oReadStudent s = students[0];

            Assert.Equals(oReadStudent, oNewStudent);
        }
    }
}
