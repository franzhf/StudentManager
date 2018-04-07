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
                handleFile.Path = szLine;
                oRepo = new StudentRepository(handleFile.Read());
                oManager = new StudentManager(oRepo, handleFile);                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Cannot load the CSV file");
                
            }
            
            if(oManager!= null)
            {
                Console.WriteLine("Search Operation - Enter a command (e.g name=ana type=kinder");
                szLine = Console.ReadLine();
                Print(oManager.Search(szLine));
            }


            Console.WriteLine("Create Operation - Enter file path (e.g create.csv");          
            szLine = Console.ReadLine();
            oManager.Save(handleFile.Read(szLine));
            oManager.Sync();
            Print(oRepo.GetContext());


            Console.Read();
        }

        private static void CreateOption()
        {
            
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
