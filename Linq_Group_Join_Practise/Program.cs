using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Group_Join_Practise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students = new List<Students>
            {
                new Students { StudentId = 1, StudentName = "Ali", ClassId = 1 },
                new Students { StudentId = 2, StudentName = "Ayşe", ClassId = 2 },
                new Students { StudentId = 3, StudentName = "Mehmet", ClassId = 1 },
                new Students { StudentId = 4, StudentName = "Fatma", ClassId = 3 },
                new Students { StudentId = 5, StudentName = "Ahmet", ClassId = 2 }
            };

            List<Classes> classes = new List<Classes>
            {
                new Classes { ClassId = 1, ClassName = "Matematik" },
                new Classes { ClassId = 2, ClassName = "Türkçe" },
                new Classes { ClassId = 3, ClassName = "Kimya" }
            };

            //group join query syntax

            var result = from c in classes
                         join s in students on c.ClassId equals s.ClassId into g
                         select new
                         {
                             Name = c.ClassName,
                             Students = g
                         };

            foreach (var item in result)
            {
                Console.WriteLine($"Class Name: {item.Name}");
                foreach (var student in item.Students)
                {
                    Console.WriteLine($"Student Name: {student.StudentName}");
                }
                Console.WriteLine("******************");
            }
        }
    }
}
