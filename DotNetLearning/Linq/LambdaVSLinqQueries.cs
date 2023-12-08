using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudents()
        {
            var students = new List<Student>();

            var student1 = new Student()
            {
                Id = 1,
                Name = "Govind",
                Gender = "Male"
            };
            students.Add(student1);

            var student4 = new Student()
            {
                Id = 1,
                Name = "Selvi",
                Gender = "Female"
            };
            students.Add(student4);


            var student2 = new Student()
            {
                Id = 1,
                Name = "Krishna",
                Gender = "Male"
            };
            students.Add(student2);


            var student3 = new Student()
            {
                Id = 1,
                Name = "Divya",
                Gender = "Female"
            };
            students.Add(student3);

            return students;
        }
    }
    internal class LambdaVSLinqQueries
    {
       
    }
}
