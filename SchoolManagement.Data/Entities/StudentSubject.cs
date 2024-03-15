using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data.Entities
{
    public class StudentSubject
    {
        [Key]
        public int StudentSubjectID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subjects Subject { get; set; }

    }
}
