using FinSAD.Domain.Entities;
using FinSAD.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using FinSAD.Domain.Interfaces;
using FinSAD.Application.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// Ensure the correct namespace for ICategoryRepository is included above.
// If ICategoryRepository is not defined, create it in FinSAD.Domain.Interfaces or the appropriate location.

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
                .FirstOrDefaultAsync(u => u.Id == userId);

            return user?.Categories ?? Enumerable.Empty<Category>();
        }

        public async Task AddAsync(Category category, int userId, CancellationToken cancellationToken)
        {
            var user = await context.Users.FirstOrDefaultAsync(u => u.Id == userId, cancellationToken);

            if(user == null) throw new Exception("User not found for adding category");

            user.Categories.Add(new Category{
                Title = category.Title,
                Description = category.Description,
            });

            context.Update(user);
            await context.SaveChangesAsync(cancellationToken);
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
