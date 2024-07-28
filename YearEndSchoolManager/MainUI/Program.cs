using Repositories.Entities;
using Services;

namespace MainUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cabinet<Student> studentCabinet = new Cabinet<Student>();
            studentCabinet.Add(new Student(id: "SE875376", name: "Doe", email: "doe123@gmail.com", yob: 2000, gpa: 8.6));
            studentCabinet.Add(new Student(id: "SE875377", name: "John", email: "john123@gmail.com", yob: 2000, gpa: 8.0));
            studentCabinet.Add(new Student(id: "SE875378", name: "Jane", email: "jane123@gmail.com", yob: 2000, gpa: 8.2));

            studentCabinet.GetAll();

            Cabinet<Lecturer> lecturerCabinet = new Cabinet<Lecturer>();
            lecturerCabinet.Add(new Lecturer(id: "L875376", name: "Daoe", email: "daoe@gmail.com", yob: 1999, salary: 15000));
            lecturerCabinet.Add(new Lecturer(id: "L934376", name: "John Kin", email: "johnkin@gmail.com", yob: 1989, salary: 23000));
            lecturerCabinet.Add(new Lecturer(id: "L985396", name: "June", email: "june@gmail.com", yob: 1980, salary: 53000));

            lecturerCabinet.GetAll();
        }
    }
}
