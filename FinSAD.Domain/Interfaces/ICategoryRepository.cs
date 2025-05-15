using FinSAD.Domain.Entities;

namespace FinSAD.Domain.Interfaces
{
    public interface ICategoryRepository
    {
        Task<Category?> GetByIdAsync(int id);
        Task<IEnumerable<Category>> GetAllByUserIdAsync(int userId);
        Task AddAsync(Category category, int userId, CancellationToken cancellationToken);
        Task UpdateAsync(Category category);
        Task DeleteAsync(Category category);
        Task<bool> ExistsAsync(int id);
    }
}
