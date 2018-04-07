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
                                    , FileCSVHelper.ConvertTimeStampForCSV(oCurrentDate));
            Assert.AreEqual(szOutput, szExpectResult);
        }

        [TestMethod]
        public void ParserCSVFormatToStudent()
        {
            // Expect Result:   Student {}
            DateTime oCurrentDate = DateTime.Now;
            string szInput = string.Format("High,Jhon,M,{0}"
                              , FileCSVHelper.ConvertTimeStampForCSV(oCurrentDate));
            Student oOutput = FileCSVHelper.ParserCSVFormatToStudent(szInput);
            Student oExpectResult = HelpfulData.CreateOneStudent(oCurrentDate);
            Assert.AreEqual(oOutput.TimeStamp.ToLongDateString(), oExpectResult.TimeStamp.ToLongDateString());
        }

        [TestMethod]
        public void ConvertTimeStampForCSV()
        {
            //  Expect Result: 20181231180120
            DateTime oInputDate = DateTime.Now;
            string szOutputDate = FileCSVHelper.ConvertTimeStampForCSV(oInputDate);
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
        public void ConvertCSVDateToTimeStamp()
        {
            // Expect Result:   Student {}
            DateTime oExpectResult = DateTime.Now;
            string szInputDate = string.Format("2018{0}{1}{2}{3}{4}"
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Month)
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Day)
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Hour)
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Minute)
                                ,FileCSVHelper.KeepInTwoDigit(oExpectResult.Second));

            DateTime oOutputDate = FileCSVHelper.ConvertCSVDateToTimeStamp(szInputDate);

            Assert.AreEqual(FileCSVHelper.ConvertTimeStampForCSV(oOutputDate), FileCSVHelper.ConvertTimeStampForCSV(oExpectResult));
        }

    }
}
