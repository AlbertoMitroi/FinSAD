import { Component, OnInit } from '@angular/core';
import { CardsService } from '../../services/cards.service';
import { CardModel } from '../../models/CardModels';
import { NgFor } from '@angular/common';
import { RouterModule } from '@angular/router';

@Component({
  selector: 'app-cards',
  imports: [NgFor, RouterModule],
  templateUrl: './cards.component.html',
  styleUrls: ['./cards.component.css']
})
export class CardsComponent implements OnInit {
cards: CardModel[] = [];

constructor(private cardsService: CardsService) {}

ngOnInit() {
  this.cardsService.getCards().subscribe({
    next: (data) => {
      this.cards = data;
    },
    error: (err) => {
      console.error('Failed to fetch cards:', err);
    }
  });
}
}
