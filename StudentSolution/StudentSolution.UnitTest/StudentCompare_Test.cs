using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentSolution.Data;

namespace StudentSolution.UnitTest
{
    [TestClass]
    public class StudentCompare_Test
    {
        [TestMethod]
        public void Compare_NamePropertySetUp()
        {
            // a == b are equals if any property value matching
            // a.Name = ana , b.Name = ana :  true
            // a.Type = Kinder, b.Type = null
            // a.Type
            // a.Name = ana , b.Name = ana ; a.Type = kinder , b.Type = High :  false

            Student a = HelpfulData.CreateOneStudent(DateTime.Now);
            Student b = new Student
            {
                Name = "Jhon"
            };

            bool bOutput = a.Compare(b);
            Assert.IsTrue(bOutput);            
        }

        [TestMethod]
        public void Compare_NameAndTypeSetUp()
        {
            // a == b are equals if any property value matching
            // a.Name = ana , b.Name = ana :  true
            // a.Type = Kinder, b.Type = null
            // a.Type
            // a.Name = ana , b.Name = ana ; a.Type = kinder , b.Type = High :  false

            Student a = HelpfulData.CreateOneStudent(DateTime.Now);
            Student b = new Student
            {
                Name = "Jhon",
                Type = StudentType.High
            };
            
            bool bOutput = a.Compare(b);
            Assert.IsTrue(bOutput);
        }

        [TestMethod]
        public void Compare_NameAndGenderSetUp()
        {
            // a == b are equals if any property value matching
            // a.Name = ana , b.Name = ana :  true
            // a.Type = Kinder, b.Type = null
            // a.Type
            // a.Name = ana , b.Name = ana ; a.Type = kinder , b.Type = High :  false

            Student a = HelpfulData.CreateOneStudent(DateTime.Now);
            Student b = new Student
            {
                Name = "Jhon",
                Gender = "M"
            };

            bool bOutput = a.Compare(b);
            Assert.IsTrue(bOutput);
        }

        [TestMethod]
        public void Compare_NameAndGenderAndTypeSetUp()
        {
            // a == b are equals if any property value matching
            // a.Name = ana , b.Name = ana :  true
            // a.Type = Kinder, b.Type = null
            // a.Type
            // a.Name = ana , b.Name = ana ; a.Type = kinder , b.Type = High :  false

            Student a = HelpfulData.CreateOneStudent(DateTime.Now);
            Student b = new Student
            {
                Name = "Jhon",
                Gender = "M",
                Type = StudentType.High
            };

            bool bOutput = a.Compare(b);
            Assert.IsTrue(bOutput);
        }
    }
}
