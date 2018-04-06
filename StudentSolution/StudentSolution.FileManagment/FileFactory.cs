using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSolution.FileManagment
{
    public class FileFactory : IFileFactory
    {
        public IHandleFile GetFileType(string szType)
        {
            IHandleFile oHandle = null;
            switch(szType)
            {
                case "CSV":  oHandle = new FileCSV(); break;
                    
            }

            return oHandle;
        }
    }
}
