using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeKnowledgeSystem.Domain.DTOs
{
    public class CreateTreeStudentRequest
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string StudentName { get; set; }

        [Required]
        public DateTime? DateOfBirth { get; set; }

    }
}
