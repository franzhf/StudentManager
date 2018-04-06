using System;
using System.Collections.Generic;
using System.Text;
using StudentSolution.Data;
namespace StudentSolution.FileManagment
{
    static class FileCSVHelper
    {
        public static string ParserStudentToCSVFormat(Student oStudent)
        {
            StringBuilder oSb = new StringBuilder();
            oSb.AppendLine(oStudent.Type.ToString());
            oSb.AppendLine(oStudent.Name);
            oSb.AppendLine(oStudent.Gender);
            oSb.AppendLine(ConvertTimeSpamForCSV(oStudent.TimeSpam));            
            return oSb.ToString();
        }

        public static string ConvertTimeSpamForCSV(DateTime oDate)
        {
            StringBuilder oSb = new StringBuilder();
            oSb.AppendLine(oDate.Year.ToString());
            oSb.AppendLine(oDate.Month.ToString());
            oSb.AppendLine(oDate.Day.ToString());
            oSb.AppendLine(oDate.Hour.ToString());
            oSb.AppendLine(oDate.Second.ToString());
            oSb.AppendLine(oDate.Millisecond.ToString());

            return oSb.ToString();
        }
        public static StudentType SetStudentType(string value)
        {
            StudentType oType = StudentType.High;

            if (value == StudentType.High.ToString())
                oType = StudentType.High;
            else if (value == StudentType.Elementary.ToString())
                oType = StudentType.Elementary;
            else if (value == StudentType.university.ToString())
                oType = StudentType.university;
            else if (value == StudentType.Kinder.ToString())
                oType = StudentType.Kinder;

            return oType;
        }


        public static Student ParserCSVFormatToStudent(string szLine)
        {
            string [] oLines = szLine.Split(',');
            Student student = new Student()
            {
                Type = SetStudentType(oLines[0]),
                Name = oLines[1],
                Gender = oLines[2]
            };
            return student;
        }


    }
}
