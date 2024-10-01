using SchoolClassManagmentProject.Models.AppExceptions;

namespace SchoolClassManagmentProject.Models.Entities
{
    internal class Teacher
    {
        private string _name { get; set; }
        private int _age { get; set; }
        private string _subjects { get; set; }
        //private int _noOfSubjects { get; set; }
        private string _phoneNumber { get; set; }
        private string _email { get; set; }

        public Teacher(string Name, int Age, string Subjets, int NoOfSubjects, string PhoneNumber, string Email)
        {
            _name = Name;
            _age = Age;
            _subjects = Subjects;
           /* int NoOfSubjects = 1;
            for (int i = 0; i < Subjets.Length; i++)
            {
                if (Subjects[i] == ',') NoOfSubjects++;
            }
            _moOfSubjects = NoOfSubjects;*/
            _phoneNumber = PhoneNumber;
            _email = Email;
        }
        public bool HasEmail => !string.IsNullOrEmpty(_email);
        public bool HasPhoneNumber => !string.IsNullOrEmpty(_phoneNumber);



    }
}