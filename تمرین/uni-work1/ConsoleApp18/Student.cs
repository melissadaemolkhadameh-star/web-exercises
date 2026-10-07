namespace Students
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string NationalID { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }

        public void ShowScore(double score)
        {
            System.Console.WriteLine($"{LastName}'s score is {score}.");
        }

        public void AttendClass()
        {
            System.Console.WriteLine($"{LastName} is in class.");
        }
    }
}
