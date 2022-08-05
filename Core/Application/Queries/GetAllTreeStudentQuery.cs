using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TreeKnowledgeSystem.Domain.Entities;
using TreeKnowledgeSystem.Domain.Repositories;
using TreeKnowledgeSystem.Infrastructure.Data;
using TreeKnowledgeSystem.Infrastructure.Repositories;

namespace TreeKnowledgeSystem.Application.Queries
{

    public class GetAllTreeStudentQuery : IRequest<IEnumerable<TreeStudent>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllTreeStudentQuery, IEnumerable<TreeStudent>>
        {
            private readonly ITreeStudentRepository _treeStudentRepository;
            public GetAllProductsQueryHandler(ITreeStudentRepository treeStudentRepository)
            {
                _treeStudentRepository = treeStudentRepository;
            }
            public async Task<IEnumerable<TreeStudent>> Handle(GetAllTreeStudentQuery query, CancellationToken cancellationToken)
            {
                var treeStudentList = await _treeStudentRepository.GetAllAsync();
                //if (productList == null)
                //{
                //    return null;
                //}
                return treeStudentList;
            }
        }
    }

    //public record Query() : IRequest<List<TreeStudent>>;
    //public class GetAllTreeStudentQuery : IRequestHandler<Query, List<TreeStudent>>
    //{
    //private readonly ITreeStudentRepository _treeStudentRepository;
    //public GetAllTreeStudentQuery(ITreeStudentRepository treeStudentRepository)
    //    {
    //    _treeStudentRepository = treeStudentRepository;
    //    }

    //    public async Task<List<TreeStudent>> Handle(Query request, CancellationToken cancellationToken)
    //    {
    //    return (List<TreeStudent>)await _treeStudentRepository.GetAllAsync();
    //    }
    //}
}
