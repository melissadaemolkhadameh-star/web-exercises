namespace Teachers
{
    public class Teacher
    {
        public int TeacherID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalID { get; set; }
        public int Age { get; set; }
        public string ClassSubject { get; set; }

        public void GiveExam()
        {
            System.Console.WriteLine($"{LastName} is giving an exam.");
        }

        public void GiveScore()
        {
            System.Console.WriteLine($"{LastName} is giving a score.");
        }
    }
}
