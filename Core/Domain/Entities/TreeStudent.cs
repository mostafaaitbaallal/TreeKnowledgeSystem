using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeKnowledgeSystem.Domain.Entities
{
    public partial class TreeStudent
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public int StudentFirstID { get; set; }

        //public virtual TreeStudentAdress TreeStudentAdress { get; set; }


    }
}
