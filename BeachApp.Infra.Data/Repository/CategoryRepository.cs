using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeachApp.Domain.Entities;
using BeachApp.Domain.Interfaces.Generic;
using BeachApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BeachApp.Infra.Data.Repository
{
    public class CategoryProductRepository : IGenericRepository<CategoryProduct>
    {   

        private readonly AppDbContext _context;

        public CategoryProductRepository(AppDbContext context)
        {
            _context = context;
        }

       public async Task CreateEntityAsync(CategoryProduct entity)
        {
           await _context.AddAsync<CategoryProduct>(entity);
           await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteEntityAsync(CategoryProduct entity)
        {
            _context.Remove<CategoryProduct>(entity);
            if(await _context.SaveChangesAsync() > 0) return true;
            return false;
        }
        public async Task<bool> UpdateEntityAsync(CategoryProduct entity)
        {
           _context.Update<CategoryProduct>(entity);
            if(await _context.SaveChangesAsync() > 0) return true;
            return false;
        }
        public async Task<IEnumerable<CategoryProduct>> GetAllEntityAsync(int? id)
        {
            IQueryable<CategoryProduct> query = _context.CategoryProducts;

            if(id.HasValue && id != 0 && id > 0)
            {
                query.Where(x => x.CompanyId == id);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<CategoryProduct> GetByIdAsync(int id)
             => await _context.CategoryProducts.FindAsync(id);    
    }
}