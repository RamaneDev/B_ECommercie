using Core.Entities;
using Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ProductRepo : IProductRepo
    {
        private readonly StoreDbContext _dbContext;

        public ProductRepo(StoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }  

        public async Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            return await _dbContext.Brands.ToListAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
           return await _dbContext.FindAsync<Product>(id);
        }

        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _dbContext.Products.ToListAsync();
        }

        public async Task<IReadOnlyList<ProductType>> GetProductTypesAsync()
        {
            return await _dbContext.Types.ToListAsync();
        }
    }
}
