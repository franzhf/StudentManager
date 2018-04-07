using System;
using System.Collections.Generic;
using System.Text;
using StudentSolution.Data;
namespace StudentSolution.FileManagment
{
    public static class FileCSVHelper
    {
        public static string ParserStudentToCSVFormat(Student oStudent)
        {
            StringBuilder oSb = new StringBuilder();
            oSb.Append(oStudent.Type.ToString());
            oSb.Append(",");
            oSb.Append(oStudent.Name);
            oSb.Append(",");
            oSb.Append(oStudent.Gender);
            oSb.Append(",");
            oSb.Append(ConvertTimeSpamForCSV(oStudent.TimeSpam));            
            return oSb.ToString();
        }
                
        public static Student ParserCSVFormatToStudent(string szLine)
        {
            string [] oLines = szLine.Split(',');
            Student student = new Student()
            {
                Name = oLines[1],
                Gender = oLines[2],
                TimeSpam = ConvertCSVDateToTimeSpam(oLines[3])
            };
            student.SetStudentType(oLines[0]);
            return student;
        }

        public static string ConvertTimeSpamForCSV(DateTime oDate)
        {
            StringBuilder oSb = new StringBuilder();
            oSb.Append(oDate.Year.ToString());
            // if is minor THAN 10, will still keep two digits fill it with a zero 
            oSb.Append(KeepInTwoDigit(oDate.Month));
            oSb.Append(KeepInTwoDigit(oDate.Day));
            oSb.Append(KeepInTwoDigit(oDate.Hour));
            oSb.Append(KeepInTwoDigit(oDate.Minute));
            oSb.Append(KeepInTwoDigit(oDate.Second));

            return oSb.ToString();
        }

        public static DateTime ConvertCSVDateToTimeSpam(string szTimeSpam)
        {
            //20186418120
            //20181218120
            //20181231180120


            string szYear = szTimeSpam.Substring(0,4);            
            string szMonth = szTimeSpam.Substring(4, 2);
            string szDay = szTimeSpam.Substring(6, 2);
            string szHour = szTimeSpam.Substring(8, 2);
            string szMinute = szTimeSpam.Substring(10, 2);
            string szSecond = szTimeSpam.Substring(12, 2);

            //"yyyy-MM-dd HH:mm:ss"
            DateTime oResult = DateTime.Parse( string.Format("{0}-{1}-{2} {3}:{4}:{5}", szYear, szMonth, szDay, szHour, szMinute, szSecond));
            return oResult;
        }

        public static string KeepInTwoDigit(int iNumber)
        {
            return iNumber < 10 ? "0" + iNumber.ToString() : iNumber.ToString();
        }
    }
}
