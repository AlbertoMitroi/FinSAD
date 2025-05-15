using FinSAD.Application.DTOs;
using FinSAD.Domain.Interfaces;
using MediatR;

namespace FinSAD.Application.Features.Cards.Queries
{
    public sealed record GetCardsByUserIdQuery(int userId) : IRequest<List<CardDto>>;
    internal class GetCardsByUserIdQueryHandler(
        ICardRepository cardRepository
        ) : IRequestHandler<GetCardsByUserIdQuery, List<CardDto>>
    {
        public async Task<List<CardDto>> Handle(GetCardsByUserIdQuery request, CancellationToken cancellationToken)
        {
            var cards = await cardRepository.GetAllByUserIdAsync(request.userId);

            var cardDtos = cards.Select(card => new CardDto
            {
                Id = card.Id,
                Currency = card.Currency,
                Amount = card.Amount.ToString(),
                Holder = card.Holder,
                Expiry = card.Expiry.ToString("MM/yy"),
                Cvv = card.Cvv,
                CurrencyLogo = card.CurrencyLogo,
                ProviderLogo = card.ProviderLogo
            }).ToList();

            return cardDtos ?? [];
        }
    }
}
