using SchoolClassManagmentProject.Models.AppExceptions;

namespace SchoolClassManagmentProject.Models.Entities
{
    public class SchoolClass
    {
        private byte _grade;
        private char _gradeLetter;
        private byte _lastGrade;
        public SchoolClass()
        {
            _grade = byte.MinValue;
            _gradeLetter = char.MinValue;
        }

        public SchoolClass(byte grade, char gradeLetter, byte lastGrade)
        {
            _grade = grade;
            _gradeLetter = gradeLetter;
            _lastGrade = lastGrade;
        }

        public byte Grade { get => _grade; set => _grade = value; }
        public char GradeLetter { get => _gradeLetter; set => _gradeLetter = value; }
        public byte LastGrade { get => _lastGrade; private set => _lastGrade = value; }
        public string Name => $"{_grade}. {_gradeLetter}";
        public bool HasGraduated => _grade > _lastGrade;
        public bool IsGraduate => _grade == _lastGrade;
        public bool NotGraduate => !HasGraduated;

        public void SetLastGrade(byte newLastGrade)
        {
            if (newLastGrade > _grade)
                LastGrade = newLastGrade;
            else
                throw new LastGradeModificationErrorException($"{nameof(SchoolClass)} osztályba, {nameof(SetLastGrade)} metódusban paraméter hiba történt.", nameof(newLastGrade),null);
        }

        public void AdvanceGrade()
        {
            if (!HasGraduated)
                Grade = (byte) (Grade + 1);
        }

        ~SchoolClass()
        {
            Console.WriteLine($"{_grade}. {_gradeLetter} osztály megszünt.");
        }
    }
}
