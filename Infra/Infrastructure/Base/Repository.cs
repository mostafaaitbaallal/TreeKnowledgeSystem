using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeKnowledgeSystem.Domain.Entities;
using TreeKnowledgeSystem.Domain.Repositories.Base;
using TreeKnowledgeSystem.Infrastructure.Data;

namespace TreeKnowledgeSystem.Infrastructure.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly TreeKnowledgeSystemContext _treeKnowledgeSystemContext;
        public Repository(TreeKnowledgeSystemContext treeKnowledgeSystemContext)
        {
            _treeKnowledgeSystemContext = treeKnowledgeSystemContext;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _treeKnowledgeSystemContext.Set<T>().AddAsync(entity);
            await _treeKnowledgeSystemContext.SaveChangesAsync();
            return entity;
        }
        public async Task DeleteAsync(T entity)
        {
            _treeKnowledgeSystemContext.Set<T>().Remove(entity);
            await _treeKnowledgeSystemContext.SaveChangesAsync();
        }
        public async Task<IReadOnlyList<T>> GetAllAsync()
        {
            return await _treeKnowledgeSystemContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _treeKnowledgeSystemContext.Set<T>().FindAsync(id);
        }
        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
