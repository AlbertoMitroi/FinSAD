import { Component, OnInit } from '@angular/core';
import { CardsService } from '../../services/cards.service';
import { CardModel } from '../../models/CardModels';
import { CommonModule, NgFor } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-cards',
  imports: [NgFor, RouterModule, CommonModule],
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.css']
})
export class CardsComponent implements OnInit {
  cards: CardModel[] = [];
  displayCards: CardModel[] = [];

  constructor(private cardsService: CardsService) {}

ngOnInit() {
  this.cardsService.getCards().subscribe({
    next: (data) => {
      this.cards = [data[0]];
      this.displayCards = this.cards.slice(0, 3);
      const placeholdersNeeded = 3 - this.displayCards.length;
      for (let i = 0; i < placeholdersNeeded; i++) {
        this.displayCards.push({
          currency: '',
          amount: '',
          holder: 'No card added',
          expiry: '',
          cvv: '',
          currencyLogo: 'placeholder.png',
          providerLogo: 'add-card.png'
        });
      }
    },
    error: (err) => {
      console.error('Failed to fetch cards:', err);
    }
  });
}
}