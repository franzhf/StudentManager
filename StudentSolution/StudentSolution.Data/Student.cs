using System;

namespace StudentSolution.Data
{
    public enum StudentType
    {
        None, // avoid the automatic set up
        Kinder,
        Elementary,
        High,
        university
    }

    public class Student
    {
       

        public string Name { get; set; }

        public StudentType Type { get; set; }

        public string Gender { get; set; }

        public DateTime TimeSpam { get; set; }

        public bool Compare(Student b)
        {
            // a == b are equals if any property value matching
            // a.Name = ana , b.Name = ana :  true
            // a.Name = ana , b.Name = ana ; a.Type = kinder , b.Type = High :  false
            if (SoftComparison(b) == true)
                return true;
            if (MediumComparison(b) == true)
                return true;
            if (HardComparison(b) == true)
                return true;
            return false;
            
        }

        /// <summary>
        /// this.Name = ana  , b.Name = ana
        /// b.type = None
        /// b.gender = null
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        private bool SoftComparison(Student b)
        {
            if (b.Name != null && b.Gender == null && b.Type == StudentType.None)
                return b.Name == this.Name;
            if (b.Name == null && b.Gender != null && b.Type == StudentType.None)
                return b.Gender == this.Gender;
            if (b.Name == null && b.Gender == null && b.Type != StudentType.None)
                return b.Type == this.Type;

            return false;
        }

        private bool MediumComparison(Student b)
        {
            if (b.Name != null && b.Gender != null && b.Type == StudentType.None)
                return b.Name == this.Name && b.Gender == this.Gender; 
            if (b.Name == null && b.Gender != null && b.Type != StudentType.None)
                return b.Gender == this.Gender && b.Type == this.Type; 
            if (b.Name != null && b.Gender == null && b.Type != StudentType.None)
                return b.Type == this.Type && b.Name == this.Name;
            return false;
        }

        private bool HardComparison(Student b)
        {
            if (b.Name != null && b.Gender != null && b.Type != StudentType.None)
                return b.Name == this.Name && b.Gender == this.Gender && b.Type == this.Type;
            return false;
        }

        public void SetStudentType(string value)
        {
            StudentType oType = StudentType.High;

            if (value.ToLower() == StudentType.High.ToString().ToLower())
                oType = StudentType.High;
            else if (value.ToLower() == StudentType.Elementary.ToString().ToLower())
                oType = StudentType.Elementary;
            else if (value.ToLower() == StudentType.university.ToString().ToLower())
                oType = StudentType.university;
            else if (value.ToLower() == StudentType.Kinder.ToString().ToLower())
                oType = StudentType.Kinder;

            Type = oType;
        }

    }
}
