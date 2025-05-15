import { CommonModule, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { CardsService } from '../../services/cards.service';
import { CardModel } from '../../models/CardModels';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-wallet-main',
  imports: [NgFor, CommonModule],
  templateUrl: './wallet-main.component.html',
  styleUrl: './wallet-main.component.css',
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
      error: (err) => console.error('Eroare la preluarea cardurilor:', err),
    });
  }

  private calculateTotalBalance(cards: CardModel[]): number {
    return cards.reduce((sum, card) => {
      const numeric = Number(
        card.amount.replace(/[^0-9.-]+/g, '').replace(',', '')
      );
      return sum + (isNaN(numeric) ? 0 : numeric);
    }, 0);
  }

  editCard(index: number) {
    const card = this.tokens[index];
    const savedTheme = localStorage.getItem('theme');
    const customClass = savedTheme === 'dark' ? 'swal2-dark' : '';

    Swal.fire({
      title: 'Edit Card',
      html: `
      <input id="swal-input1" class="swal2-input" placeholder="Currency" value="${card.currency}">
      <input id="swal-input2" class="swal2-input" placeholder="Amount" value="${card.amount}">
      <input id="swal-input3" class="swal2-input" placeholder="Holder" value="${card.holder}">
      <input id="swal-input4" class="swal2-input" placeholder="Expiry" value="${card.expiry}">
      <input id="swal-input5" class="swal2-input" placeholder="CVV" value="${card.cvv}">
    `,
      customClass: {
        popup: customClass,
      },
      showCancelButton: true,
      confirmButtonText: 'Save',
      focusConfirm: false,
      preConfirm: () => {
        const currency = (
          document.getElementById('swal-input1') as HTMLInputElement
        ).value;
        const amount = (
          document.getElementById('swal-input2') as HTMLInputElement
        ).value;
        const holder = (
          document.getElementById('swal-input3') as HTMLInputElement
        ).value;
        const expiry = (
          document.getElementById('swal-input4') as HTMLInputElement
        ).value;
        const cvv = (document.getElementById('swal-input5') as HTMLInputElement)
          .value;

        if (!currency || !amount || !holder) {
          Swal.showValidationMessage('Please fill in all required fields');
          return;
        }

        return { currency, amount, holder, expiry, cvv };
      },
    }).then((result) => {
      if (result.isConfirmed && result.value) {
        this.tokens[index] = {
          ...this.tokens[index],
          ...result.value,
        };
        this.calculateTotalBalance(this.tokens);
        Swal.fire('Updated!', 'Your card has been updated.', 'success');
      }
    });
  }
  deleteCard(index: number) {
    const savedTheme = localStorage.getItem('theme');
    const customClass = savedTheme === 'dark' ? 'swal2-dark' : '';

    Swal.fire({
      title: 'Are you sure?',
      text: 'You will not be able to recover this card!',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#3085d6',
      cancelButtonColor: '#d33',
      confirmButtonText: 'Yes, delete it!',
      cancelButtonText: 'Cancel',
      customClass: {
        popup: customClass,
      },
    }).then((result) => {
      if (result.isConfirmed) {
        this.tokens.splice(index, 1);
        this.calculateTotalBalance(this.tokens);

        Swal.fire({
          title: 'Deleted!',
          text: 'The card has been deleted.',
          icon: 'success',
          customClass: {
            popup: customClass,
          },
        });
      }
    });
  }
}
