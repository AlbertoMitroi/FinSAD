using FinSAD.Domain.Entities;

namespace FinSAD.Domain.Interfaces
{
    public interface ICardRepository
    {
        Task<Card?> GetByIdAsync(int id);
        Task<IEnumerable<Card>> GetAllByUserIdAsync(int userId);
        Task AddAsync(Card card);
        Task UpdateAsync(Card card);
        Task DeleteAsync(Card card);
        Task<bool> ExistsAsync(int id);
    }
}
