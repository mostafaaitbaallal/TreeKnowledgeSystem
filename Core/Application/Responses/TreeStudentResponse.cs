using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeKnowledgeSystem.Application.Responses
{
    public class TreeStudentResponse
    {
        public int StudentID { get; set; }
        public string? StudentFirstName { get; set; }

        public string? StudentLastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
