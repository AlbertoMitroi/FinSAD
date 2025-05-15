

// namespace FinSAD.Application.Features.Categories.Commands;
// @@ -0,0 +1,39 @@
// using System;
// using FinSAD.Application.DTOs;
// using FinSAD.Domain.Entities;
// using FinSAD.Domain.Interfaces;
// using MediatR;
// public sealed record AddCardCommand(CardPostDto CardPostDto, int userId) : IRequest<CardDto>;
// public class AddCardCommandHandler(
//     ICardRepository cardRepository
// ) : IRequestHandler<AddCardCommand, CardDto>
// {
//     public async Task<CardDto> Handle(AddCardCommand request, CancellationToken cancellationToken)
//     {
//         var card = new Card
//         {
//             Currency = request.CardPostDto.Currency,
//             Amount = request.CardPostDto.Amount,
//             Holder = request.CardPostDto.Holder,
//             Expiry = request.CardPostDto.Expiry,
//             Cvv = request.CardPostDto.Cvv,
//             CurrencyLogo = request.CardPostDto.CurrencyLogo,
//             ProviderLogo = request.CardPostDto.ProviderLogo
//         };

//         await cardRepository.AddAsync(card, request.userId, cancellationToken);

//         return new CardDto
//         {
//             Currency = card.Currency,
//             Amount = card.Amount.ToString(),
//             Holder = card.Holder,
//             Expiry = card.Expiry.ToString("yyyy-MM-dd HH:mm:ss"),
//             Cvv = card.Cvv,
//             CurrencyLogo = card.CurrencyLogo,
//             ProviderLogo = card.ProviderLogo
//         };
//     }
// }