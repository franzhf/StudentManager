using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using StudentSolution.Data;
using System.IO;
namespace StudentSolution.FileManagment
{
    public class FileCSV : IHandleFile
    {
        public IEnumerable<Student> Read(string szPath)
        {
            List<Student> oStudents = new List<Student>();
            using (StreamReader oFile = new StreamReader(szPath))
            {
                string szLine = oFile.ReadLine();
                while(!string.IsNullOrEmpty(szLine ))
                {
                    oStudents.Add(FileCSVHelper.ParserCSVFormatToStudent(szLine));
                    szLine = oFile.ReadLine();
                }                
            }
            return oStudents;
        }

        public void Write(Student oStudent, string szPath)
        {
            using (StreamWriter file = new StreamWriter(szPath))
            {
                string szLine = FileCSVHelper.ParserStudentToCSVFormat(oStudent);
                file.Write(szLine);
            }
        }
    }
}
