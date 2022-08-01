using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeKnowledgeSystem.Domain.Entities;
using TreeKnowledgeSystem.Application.Responses;
using TreeKnowledgeSystem.Application.Commands;
using AutoMapper;

namespace TreeKnowledgeSystem.Application.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<TreeStudent, TreeStudentResponse>().ReverseMap();
            CreateMap<TreeStudent, CreateTreeStudentCommand>().ReverseMap();
        }
    }
}
