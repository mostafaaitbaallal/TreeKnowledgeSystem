using TreeKnowledgeSystem.Domain.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeKnowledgeSystem.Domain.Repositories
{
    public interface ITreeStudentRepository : IRepository<TreeKnowledgeSystem.Domain.Entities.TreeStudent>
    {
        //custom operations here
        Task<IEnumerable<TreeKnowledgeSystem.Domain.Entities.TreeStudent>> GetEmployeeByLastName(string lastname);
    }
}
