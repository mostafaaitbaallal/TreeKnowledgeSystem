using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeKnowledgeSystem.Domain.Entities;

namespace TreeKnowledgeSystem.Infrastructure.Data
{
    public class TreeKnowledgeSystemContext : DbContext
    {
        public TreeKnowledgeSystemContext(DbContextOptions<TreeKnowledgeSystemContext> options) : base(options) { }
        public DbSet<TreeStudent> TreeStudents
        {
            get;
            set;
        }
    }
}
