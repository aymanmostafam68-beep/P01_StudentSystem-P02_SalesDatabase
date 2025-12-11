using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    internal class Resource
    {
        public enum ResourceType
        {
            Video,
            Presentation,
            Document,
            Other

        }

        public int ResourceId { get; set; }
        public int CourseId { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column("ResourceType", TypeName = "varchar(50)")]
        public ResourceType Type { get; set; }
        [Column(TypeName = "varchar(255)")]
        public string Url { get; set; }

    }
}
