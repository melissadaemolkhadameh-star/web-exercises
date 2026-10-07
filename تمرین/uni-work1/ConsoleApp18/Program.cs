using System;
using Customers;
using Students;
using Teachers;
using Employees;
using ShapeRectangle;
using ShapeSquare;
using Dogs;
using Cats;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================");
            Console.WriteLine("       OOP EXERCISES");
            Console.WriteLine("======================================");
            Console.WriteLine();

            // --------------------------------------
            // Customer
            // --------------------------------------

            Customer customer = new Customer();

            customer.CustomerID = 12345;
            customer.FirstName = "Mohammad";
            customer.LastName = "Ali";
            customer.NationalID = "123456789";
            customer.Address = "Narges Street";
            customer.EmailAddress = "example@gmail.com";
            customer.PhoneNumber = "09121234567";

            customer.PlaceOrder();
            customer.CancelOrder();

            Console.WriteLine();


            // --------------------------------------
            // Student
            // --------------------------------------

            Student student = new Student();

            student.StudentID = 12345678;
            student.FirstName = "Mohammad";
            student.LastName = "Ali";
            student.FatherName = "Amir";
            student.NationalID = "123456789";
            student.Age = 16;
            student.Major = "Computer";

            student.ShowScore(20);
            student.AttendClass();

            Console.WriteLine();


            // --------------------------------------
            // Teacher
            // --------------------------------------

            Teacher teacher = new Teacher();

            teacher.TeacherID = 12345678;
            teacher.FirstName = "Mohammad";
            teacher.LastName = "Ali";
            teacher.FatherName = "Amir";
            teacher.NationalID = "123456789";
            teacher.Age = 35;
            teacher.ClassSubject = "Computer";

            teacher.GiveExam();
            teacher.GiveScore();

            Console.WriteLine();


            // --------------------------------------
            // Employee
            // --------------------------------------

            Employee employee = new Employee();

            employee.EmployeeID = 12345678;
            employee.FirstName = "Mohammad";
            employee.LastName = "Ali";
            employee.NationalID = "123456789";
            employee.Job = "Server Maintenance";

            double workHours =
                employee.CalculateWorkHours(8, 9);

            double salary =
                employee.CalculateSalary(10, workHours);

            Console.WriteLine(
                $"{employee.LastName} has worked {workHours} hours."
            );

            Console.WriteLine(
                $"{employee.LastName}'s salary is {salary}$."
            );

            Console.WriteLine();


            // --------------------------------------
            // Rectangle
            // --------------------------------------

            Rectangle rectangle = new Rectangle();

            rectangle.X = 4;
            rectangle.Y = 8;

            Console.WriteLine(
                $"Rectangle Area: {rectangle.CalculateArea()}"
            );

            Console.WriteLine(
                $"Rectangle Perimeter: {rectangle.CalculatePerimeter()}"
            );

            Console.WriteLine();


            // --------------------------------------
            // Square
            // --------------------------------------

            Square square = new Square();

            square.X = 4;
            square.Angle = 360;
            square.Sides = 4;

            Console.WriteLine(
                $"Square X: {square.CalculateX()}"
            );

            Console.WriteLine(
                $"Square Sides: {square.Sides}"
            );

            Console.WriteLine(
                $"Square Total Angle: {square.CalculateAngle()}"
            );

            Console.WriteLine();


            // --------------------------------------
            // Dog
            // --------------------------------------

            Dog dog = new Dog();

            dog.Name = "Ghahvei";
            dog.BreedType = "Shepard";
            dog.OwnerFirstName = "Mohammad";
            dog.OwnerLastName = "Ali";
            dog.Age = 2;

            Console.WriteLine(
                $"{dog.Name} is Healthy: {dog.IsHealthy()}"
            );

            Console.WriteLine(
                $"{dog.Name} is Sleeping: {dog.IsSleeping()}"
            );

            Console.WriteLine();


            // --------------------------------------
            // Cat
            // --------------------------------------

            Cat cat = new Cat();

            cat.Name = "Narenji";
            cat.BreedType = "Orange Tabby";
            cat.OwnerFirstName = "Mohammad";
            cat.OwnerLastName = "Ali";
            cat.Age = 1;

            Console.WriteLine(
                $"{cat.Name} is Healthy: {cat.IsHealthy()}"
            );

            Console.WriteLine(
                $"{cat.Name} is Sleeping: {cat.IsSleeping()}"
            );

            Console.WriteLine();


            Console.WriteLine("======================================");
            Console.WriteLine("       HTTP / HTTPS");
            Console.WriteLine("======================================");

            Console.WriteLine("HTTP: HyperText Transfer Protocol");
            Console.WriteLine("HTTPS: HTTP Secure using TLS encryption");

            Console.WriteLine();


            Console.WriteLine("======================================");
            Console.WriteLine("       URL");
            Console.WriteLine("======================================");

            Console.WriteLine(
                "https://www.example.com:443/products?id=25#details"
            );

            Console.WriteLine("Protocol : https");
            Console.WriteLine("Subdomain: www");
            Console.WriteLine("Domain   : example.com");
            Console.WriteLine("Port     : 443");
            Console.WriteLine("Path     : /products");
            Console.WriteLine("Query    : ?id=25");
            Console.WriteLine("Fragment : #details");

            Console.WriteLine();


            Console.WriteLine("======================================");
            Console.WriteLine("       GET / POST");
            Console.WriteLine("======================================");

            Console.WriteLine("GET  -> Used to retrieve information.");
            Console.WriteLine("POST -> Used to send/create information.");

            Console.WriteLine("GET Example : GET /products/25");
            Console.WriteLine("POST Example: POST /users");

            Console.WriteLine();


            Console.WriteLine("======================================");
            Console.WriteLine("       JSON");
            Console.WriteLine("======================================");

            string jsonStudent =
@"{
    ""studentId"": 12345678,
    ""firstName"": ""Mohammad"",
    ""lastName"": ""Ali"",
    ""fatherName"": ""Amir"",
    ""nationalId"": ""123456789"",
    ""age"": 16,
    ""major"": ""Computer""
}";

            Console.WriteLine(jsonStudent);

            Console.WriteLine();


            Console.WriteLine("======================================");
            Console.WriteLine("       XML");
            Console.WriteLine("======================================");

            string xmlStudent =
@"<Student>
    <StudentID>12345678</StudentID>
    <FirstName>Mohammad</FirstName>
    <LastName>Ali</LastName>
    <FatherName>Amir</FatherName>
    <NationalID>123456789</NationalID>
    <Age>16</Age>
    <Major>Computer</Major>
</Student>";

            Console.WriteLine(xmlStudent);

            Console.WriteLine();
            Console.WriteLine("======================================");
            Console.WriteLine("       ALL EXERCISES COMPLETED");
            Console.WriteLine("======================================");

            Console.ReadKey();
        }
    }
}
