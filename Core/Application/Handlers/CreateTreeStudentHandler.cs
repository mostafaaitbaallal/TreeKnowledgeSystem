using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeKnowledgeSystem.Domain.Repositories;
using TreeKnowledgeSystem.Domain.Entities;
using MediatR;
using TreeKnowledgeSystem.Application.Commands;
using TreeKnowledgeSystem.Application.Responses;
using TreeKnowledgeSystem.Application.Mappers;

namespace TreeKnowledgeSystem.Application.Handlers
{
    public class CreateTreeStudentHandler : IRequestHandler<CreateTreeStudentCommand, TreeStudentResponse>
    {
        private readonly ITreeStudentRepository _treeStudentRepository;
        public CreateTreeStudentHandler(ITreeStudentRepository treeStudentRepository)
        {
            _treeStudentRepository = treeStudentRepository;
        }
        public async Task<TreeStudentResponse> Handle(CreateTreeStudentCommand request, CancellationToken cancellationToken)
        {
            var treeStudentEntitiy = TreeStudentMapper.Mapper.Map<TreeStudent>(request);
            if (treeStudentEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newTreeStudent = await _treeStudentRepository.AddAsync(treeStudentEntitiy);
            var treeStudentResponse = TreeStudentMapper.Mapper.Map<TreeStudentResponse>(newTreeStudent);
            return treeStudentResponse;
        }
    }
}
