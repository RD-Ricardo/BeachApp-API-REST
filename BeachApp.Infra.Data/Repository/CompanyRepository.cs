using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeachApp.Domain.Entities;
using BeachApp.Domain.Interfaces.Generic;
using BeachApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BeachApp.Infra.Data.Repository
{
    public class CompanyRepository : IGenericRepository<Company>
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateEntityAsync(Company entity)
        {
           await _context.AddAsync<Company>(entity);
           await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteEntityAsync(Company entity)
        {
            _context.Remove<Company>(entity);
            if(await _context.SaveChangesAsync() > 0) return true;
            return false;
        }
        public async Task<bool> UpdateEntityAsync(Company entity)
        {
           _context.Update<Company>(entity);
            if(await _context.SaveChangesAsync() > 0) return true;
            return false;
        }
        public async Task<IEnumerable<Company>> GetAllEntityAsync(int? id)
        {
            IQueryable<Company> query = _context.Companies;
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
             => await _context.Companies.FindAsync(id);    
    }
}