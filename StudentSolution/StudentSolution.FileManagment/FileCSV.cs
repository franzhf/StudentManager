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
        public string Path { get ; set ; }

        public FileCSV(string szPath)
        {
            this.Path = szPath;
        }
        public FileCSV()
        {
        }

        public List<Student> Read()
        {
            return Read(this.Path);
        }

        public void Write(Student oStudent)
        {
            using (StreamWriter file = new StreamWriter(Path, true))
            {
                string szLine = FileCSVHelper.ParserStudentToCSVFormat(oStudent);
                file.Write(szLine);
            }
        }

        public List<Student> Read(string szPath)
        {
            List<Student> oStudents = new List<Student>();
            using (StreamReader oFile = new StreamReader(szPath))
            {
                string szLine = oFile.ReadLine();
                while (!string.IsNullOrEmpty(szLine))
                {
                    oStudents.Add(FileCSVHelper.ParserCSVFormatToStudent(szLine));
                    szLine = oFile.ReadLine();
                }
            }
            return oStudents;
        }
    }
}
