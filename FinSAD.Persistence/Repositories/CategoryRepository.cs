using FinSAD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using FinSAD.Domain.Interfaces;
using FinSAD.Application.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinSAD.Persistence.Repositories
{
    public class CategoryRepository(DataDbContext context) : ICategoryRepository
    {
        public async Task<Category?> GetByIdAsync(int id)
        {
            return await context.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetAllByUserIdAsync(int userId)
        {
            var user = await context.Users
                .Include(u => u.Categories)
                    .ThenInclude(c => c.AmountHistory)
                .FirstOrDefaultAsync(u => u.Id == userId);

            return user?.Categories ?? Enumerable.Empty<Category>();
        }

        public async Task AddAsync(Category category)
        {
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            context.Categories.Update(category);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Category category)
        {
            context.Categories.Remove(category);
            await context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await context.Categories.AnyAsync(c => c.Id == id);
        }
    }
}
