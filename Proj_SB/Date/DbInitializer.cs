using Proj_SB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_SB.Date
{
    public class DbInitializer
    {
        public static void Initiallize(SchoolContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;// it mean that there no space in the DB
            }
            var students = new Student[]
            {
                new Student{ FirstName ="Elior",LastName="Dayari",Email="EliorDayari@gmail.com",EnrollmentDate=DateTime.Parse("2020-10-11")},
                  new Student{ FirstName ="Yarin",LastName="Meron",Email="Yarinmeron1@gmail.com",EnrollmentDate=DateTime.Parse("2020-07-11")},
                    new Student{ FirstName ="Koral",LastName="Bareket",Email="KoralBareket@gmail.com",EnrollmentDate=DateTime.Parse("2020-03-05")}
            };
            foreach(Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
                new Course{ CourseID =100,Title="Infi1",Credits=4},
                   new Course{ CourseID =450,Title="Linear2",Credits=7},
                     new Course{ CourseID =200,Title="Infi2",Credits=5}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
                new Enrollment{ CourseID =100,StudentID=1,Grade=Grade.A},
                   new Enrollment{ CourseID =450,StudentID=1,Grade=Grade.B},
                   new Enrollment{ CourseID =200,StudentID=2,Grade=Grade.C},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();



        }
    }
}
