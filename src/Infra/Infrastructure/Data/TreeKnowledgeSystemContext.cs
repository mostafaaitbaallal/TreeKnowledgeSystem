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
        
        public TreeKnowledgeSystemContext()
        {
        }
        public TreeKnowledgeSystemContext(DbContextOptions<TreeKnowledgeSystemContext> options) : base(options) 
        { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=10.10.2.58;Database=TreeKnowledgeSystemDB;User Id=sa;password=123;Trusted_Connection=False;MultipleActiveResultSets=true;");
        }
        public virtual DbSet<TreeStudent> TreeStudents
        {
            get;
            set;
        }

        private readonly DbContextOptions _options;


    }
}
