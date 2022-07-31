using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeKnowledgeSystem.Domain.Entities;
using TreeKnowledgeSystem.Domain.Repositories;
using TreeKnowledgeSystem.Infrastructure.Data;
using TreeKnowledgeSystem.Infrastructure.Repositories.Base;

namespace TreeKnowledgeSystem.Infrastructure.Repositories
{
    public class TreeStudentRepository : Repository<TreeStudent>, ITreeStudentRepository
    {
        public TreeStudentRepository(TreeKnowledgeSystemContext treeKnowledgeSystemContext) : base(treeKnowledgeSystemContext) { }
        public async Task<IEnumerable<TreeStudent>> GetEmployeeByLastName(string lastname)
        {
            return await _employeeContext.Employees.Where(m => m.LastName == lastname).ToListAsync();
        }
    }
}
