using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSolution.Data
{
    public static class SearchHelper
    {
        public static Student MappingStrToStudent(string szLine)
        {
            // input name=ana type=M
            // TODO use an expresion regular for validate the input
            Student oS = new Student();
            string[] szPairs = szLine.Split(' ');

            foreach(var szPair in szPairs)
            {
                // TODO: We can refactor this with reflection approach?
                string[] property = szPair.Split('=');
                if (property[0].Equals("name"))
                    oS.Name = property[1];
                else if (property[0].Equals("type"))
                    oS.SetStudentType(property[1]);
                else if (property[1].Equals("gender"))
                    oS.Gender = property[1];
            }

            return oS;
        }
    }
}
