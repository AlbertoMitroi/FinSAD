import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-wallet-main',
  imports: [NgFor],
  templateUrl: './wallet-main.component.html',
  styleUrl: './wallet-main.component.css'
})
export class WalletMainComponent {
  tokens = [
    {
      name: 'USD',
      amount: '1 BTC',
      value: '$104,643',
      price: '$104,430',
      icon: 'USD.png',
      change: '-'
    },
    {
      name: 'BGP',
      amount: '3 ETH',
      value: '$9,700',
      price: '$3,233',
      icon: 'GBP.png',
      change: '+'
    },
    {
      name: 'EURO',
      amount: '15 LTC',
      value: '$1,500',
      price: '$100',
      icon: 'EURO.png',
      change: '+'
    }
  ];
}