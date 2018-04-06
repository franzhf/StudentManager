using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSolution.FileManagment
{
    public interface IFileFactory
    {
        IHandleFile GetFileType(string szType);
    }
}
