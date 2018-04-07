using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSolution.Data;
using StudentSolution.FileManagment;

namespace StudentSolution.UnitTest
{
    [TestClass]
    public class FileCSVHelper_Test
    {
        [TestMethod]
        public void ParserStudentToCSVFormat()
        {
            // Expect Result: High,Luke,M,20180604180120
            DateTime oCurrentDate = DateTime.Now;
            Student oInput = HelpfulData.CreateOneStudent(oCurrentDate);
            string szOutput = FileCSVHelper.ParserStudentToCSVFormat(oInput);
            string szExpectResult = string.Format("High,Jhon,M,{0}"
                                    , FileCSVHelper.ConvertTimeSpamForCSV(oCurrentDate));
            Assert.AreEqual(szOutput, szExpectResult);
        }

        [TestMethod]
        public void ParserCSVFormatToStudent()
        {
            // Expect Result:   Student {}
            DateTime oCurrentDate = DateTime.Now;
            string szInput = string.Format("High,Jhon,M,{0}"
                              , FileCSVHelper.ConvertTimeSpamForCSV(oCurrentDate));
            Student oOutput = FileCSVHelper.ParserCSVFormatToStudent(szInput);
            Student oExpectResult = HelpfulData.CreateOneStudent(oCurrentDate);
            Assert.AreEqual(oOutput.TimeSpam.ToLongDateString(), oExpectResult.TimeSpam.ToLongDateString());
        }

        [TestMethod]
        public void ConvertTimeSpamForCSV()
        {
            //  Expect Result: 20181231180120
            DateTime oInputDate = DateTime.Now;
            string szOutputDate = FileCSVHelper.ConvertTimeSpamForCSV(oInputDate);
            //YYYYMMDDHHMMSS
            string szExpectResult = string.Format("2018{0}{1}{2}{3}{4}"
                                    , FileCSVHelper.KeepInTwoDigit(oInputDate.Month)
                                    , FileCSVHelper.KeepInTwoDigit(oInputDate.Day)
                                    , FileCSVHelper.KeepInTwoDigit(oInputDate.Hour)
                                    , FileCSVHelper.KeepInTwoDigit(oInputDate.Minute)
                                    , FileCSVHelper.KeepInTwoDigit(oInputDate.Second));
            Assert.AreEqual(szOutputDate, szExpectResult);
        }

        [TestMethod]
        public void ConvertCSVDateToTimeSpam()
        {
            // Expect Result:   Student {}
            DateTime oExpectResult = DateTime.Now;
            string szInputDate = string.Format("2018{0}{1}{2}{3}{4}"
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Month)
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Day)
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Hour)
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Minute)
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Second));

            DateTime oOutputDate = FileCSVHelper.ConvertCSVDateToTimeSpam(szInputDate);

            Assert.AreEqual(FileCSVHelper.ConvertTimeSpamForCSV(oOutputDate), FileCSVHelper.ConvertTimeSpamForCSV(oExpectResult));
        }

    }
}
