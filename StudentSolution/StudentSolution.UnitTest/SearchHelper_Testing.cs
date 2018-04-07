using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSolution.Business;

namespace StudentSolution.Data
{
    [TestClass]
    public class SearchHelper_Testing
    {
        [TestMethod]
        public void MappingStrToStudent()
        {
            // input name=ana type=M
            string szLineInput = "name=ana type=kinder";
            Student oS = SearchHelper.MappingStrToStudent(szLineInput);
            Assert.AreEqual(oS.Name, "ana");
            Assert.AreEqual(oS.Type.ToString().ToLower(), "kinder");
        }
    }
}
