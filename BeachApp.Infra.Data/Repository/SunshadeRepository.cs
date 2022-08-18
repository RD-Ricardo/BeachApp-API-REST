using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeachApp.Domain.Entities;
using BeachApp.Domain.Interfaces.Generic;
using BeachApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BeachApp.Infra.Data.Repository
{
    public class SunshadeRepository : IGenericRepository<Sunshade>
    {
        private readonly AppDbContext _context;
        public SunshadeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateEntityAsync(Sunshade entity)
        {
           await _context.AddAsync<Sunshade>(entity);
           await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteEntityAsync(Sunshade entity)
        {
            _context.Remove<Sunshade>(entity);
            if(await _context.SaveChangesAsync() > 0) return true;
            return false;
        }
        public async Task<bool> UpdateEntityAsync(Sunshade entity)
        {
           _context.Update<Sunshade>(entity);
            if(await _context.SaveChangesAsync() > 0) return true;
            return false;
        }
        public async Task<IEnumerable<Sunshade>> GetAllEntityAsync(int? id)
        {
            IQueryable<Sunshade> query = _context.Sunshades;

            if(id.HasValue && id != 0 && id > 0)
            {
                query.Where(x => x.CompanyId == id);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<Sunshade> GetByIdAsync(int id)
             => await _context.Sunshades.FindAsync(id);    
    }
}