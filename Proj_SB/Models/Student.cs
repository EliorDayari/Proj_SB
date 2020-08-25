using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proj_SB.Models
{
    public enum Grade
    {
        A,B,C,D,F
    }
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Grade? Grade { get; set; }

        public string Email { get; set; }
     
        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }


    }

    
}
