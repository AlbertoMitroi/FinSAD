import { CommonModule, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { CardsService } from '../../services/cards.service';
import { CardModel } from '../../models/CardModels';

@Component({
  selector: 'app-wallet-main',
  imports: [NgFor, CommonModule],
  templateUrl: './wallet-main.component.html',
  styleUrl: './wallet-main.component.css'
})
export class WalletMainComponent {
  tokens: CardModel[] = [];
  totalBalance: number = 0;

  constructor(private cardsService: CardsService) {}

  ngOnInit(): void {
    this.cardsService.getCards().subscribe({
      next: (cards) => {
        this.tokens = cards;
        this.totalBalance = this.calculateTotalBalance(cards);
      },
      error: (err) => console.error('Eroare la preluarea cardurilor:', err)
    });
  }

  private calculateTotalBalance(cards: CardModel[]): number {
    return cards.reduce((sum, card) => {
      const numeric = Number(card.amount.replace(/[^0-9.-]+/g, '').replace(',', ''));
      return sum + (isNaN(numeric) ? 0 : numeric);
    }, 0);
  }
}