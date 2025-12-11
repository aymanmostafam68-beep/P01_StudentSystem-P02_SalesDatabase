using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Homework
    {
        public enum ContentType
        {
            Application,
            Pdf,
            Zip
        }
        public int HomeworkId { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Content { get; set; }

        [Column("ContentType", TypeName = "varchar(50)")]
        public ContentType Type { get; set; }

        public DateTime SubmissionTime { get; set; }

        public int StudentId { get; set; }

        public int CourseId { get; set; }

     

    }
}
