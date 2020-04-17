namespace Rosyln_Create_A_Class
{
    using System;

    public class Person
    {
        public string Name
        {
            get;
            set;
        }

        public string Surname
        {
            get;
            set;
        }

        private string Gender
        {
            get;
            set;
        }

        public void PublicValues()
        {
            this.Name = "Buyie";
            this.Surname = "Phofuyagae";
        }

        private void GenderValue()
        {
            this.Gender = "Female";
        }
    }
}