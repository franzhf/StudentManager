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

        Student _oNewStudent;
        public HandleFile_Testing()
        {
            //
            // TODO: Add constructor logic here
            //
            _oNewStudent = new Student
            {
                Type = StudentType.High,
                Name = "Jhon",
                Gender = "Male",
                TimeSpam = DateTime.Now
            };
        }


        [TestMethod]
        public void Write_A_Student_in_CSVFile()
        {
            // I want to manage the information in a CSV file
            IFileFactory fileFactory = new FileFactory();
            IHandleFile handleFile = fileFactory.GetFileType("CSV");

            string szPath = "inputTest.csv";
            handleFile.Write(_oNewStudent, szPath);
            IEnumerable<Student> oStudents = handleFile.Read(szPath);

            Student oReadStudent = null;
            foreach (var i in oStudents)
                oReadStudent = i;

            Assert.Equals(oReadStudent, _oNewStudent);
        }
    }
}
