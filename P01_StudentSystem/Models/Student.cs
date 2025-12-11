using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string Name { get; set; }
        [Column(TypeName ="varchar(10)")]

        public string? PhoneNumber { get; set; }

        public DateTime RegisteredOn { get; set; }

        public DateOnly? Birthday { get; set; }

        public List<StudentCourse> StudentCourse { get; set; }
        public List<Homework> Homeworks { get; set; }




    }
}
