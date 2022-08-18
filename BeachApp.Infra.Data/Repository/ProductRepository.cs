using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeachApp.Domain.Entities;
using BeachApp.Domain.Interfaces.Generic;
using BeachApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BeachApp.Infra.Data.Repository
{
    public class ProductRepository : IGenericRepository<Product>
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateEntityAsync(Product entity)
        {
           await _context.AddAsync<Product>(entity);
           await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteEntityAsync(Product entity)
        {
            _context.Remove<Product>(entity);
            if(await _context.SaveChangesAsync() > 0) return true;
            return false;
        }
        public async Task<bool> UpdateEntityAsync(Product entity)
        {
           _context.Update<Product>(entity);
            if(await _context.SaveChangesAsync() > 0) return true;
            return false;
        }
        public async Task<IEnumerable<Product>> GetAllEntityAsync(int? id)
        {
            IQueryable<Product> query = _context.Products;

            if(id.HasValue && id != 0 && id > 0)
            {
              query =  query.Include(x => x.Company).Where(x => x.CompanyId == id);
            }

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetByIdAsync(int id)
             => await _context.Products.FindAsync(id);    
    }
}