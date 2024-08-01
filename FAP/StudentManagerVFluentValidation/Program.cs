using StudentManagerVFinalFantasy.Entities;
using StudentManagerVFluentValidation.Entities;

namespace StudentManagerVFluentValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap mot so bat ky");
            int a = Convert.ToInt32(Console.ReadLine());

            Student s1 = new Student
            {
                Id = 01,
                Name = "John",
                Yob = 1980,
                Gpa = 4.0
            };

            var validator = new StudentValidator();
            var result = validator.Validate(s1);

            if (result.IsValid)
            {
                System.Console.WriteLine("Student is valid");
            }
            else
            {
                foreach (var failure in result.Errors)
                {
                    Console.WriteLine($"Property {failure.PropertyName} failed validation. Error was: {failure.ErrorMessage}");
                }
            }
        }
    }
}
