using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Data.Entities
{
    public class DepartmetSubject
    {
        [Key]
        public int DepartmentSubjectID { get; set; }
        public int DepartmentID { get; set; }
        public int SubjectID { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        [ForeignKey("SubjectID")]
        public virtual Subjects Subjects { get; set; }
    }
}
