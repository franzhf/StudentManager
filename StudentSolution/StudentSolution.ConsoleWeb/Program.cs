using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSolution.FileManagment;
using StudentSolution.Data;
using StudentSolution.Business;

namespace StudentSolution.ConsoleWeb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load Operation - Enter a File Path (e.g Input.csv):");
            string szLine = Console.ReadLine();

            IFileFactory fileFactory = new FileFactory();
            IHandleFile handleFile = fileFactory.GetFileType("CSV");
            IStudentRepository oRepo = null;
            IStudentManager oManager = null;
            try
            {
                oRepo = new StudentRepository(handleFile.Read(szLine));
                oManager = new StudentManager(oRepo);                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Cannot load the CSV file");
                
            }
            
            if(oManager!= null)
            {
                Console.WriteLine("Search Operation - Enter a command (e.g name = ana type = kinder");
                szLine = Console.ReadLine();
                Print(oManager.Search(szLine));
                Console.Read();
            }


            Console.WriteLine("Create Operation - Enter a command (e.g name = ana type = kinder");
            szLine = Console.ReadLine();
            Print(oManager.Search(szLine));
            Console.Read();
        }

        private static void Print(IEnumerable<Student> collection)
        {
            foreach (var s in collection)
            {
                Console.WriteLine("Type:{0}     |Name:{1}       |Gender:{2}     | Timestamp:{3}", 
                    s.Type,s.Name,s.Gender,s.TimeStamp);
            }
        }
    }
}
