using FinSAD.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using FinSAD.Domain.Interfaces;
using FinSAD.Application.DTOs;

namespace FinSAD.Persistence.Repositories
{
    public class CardRepository(DataDbContext context) : ICardRepository
    {
        public async Task<Card?> GetByIdAsync(int id)
        {
            return await context.Cards.FindAsync(id);
        }

        public async Task<IEnumerable<Card>> GetAllByUserIdAsync(int userId)
        {
            var user = await context.Users
                .Include(u => u.Cards)
                    .ThenInclude(c => c.AmountHistory)
                .FirstOrDefaultAsync(u => int.Parse(u.Id) == userId);

            return user?.Cards ?? Enumerable.Empty<Card>();
        }

        public async Task AddAsync(Card card)
        {
            await context.Cards.AddAsync(card);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Card card)
        {
            context.Cards.Update(card);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(Card card)
        {
            context.Cards.Remove(card);
            await context.SaveChangesAsync();
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await context.Cards.AnyAsync(c => c.Id == id);
        }
    }
}
