import { Injectable } from '@angular/core';
import { Transaction } from '../models/Transaction';

@Injectable({
  providedIn: 'root'
})
export class RecentTransactionsService {
  private transactions: Transaction[] = [
    {
      service: 'Music',
      icon: 'uil-headphones-alt',
      date: '22.11.2024',
      cardImage: 'visa.png',
      cardType: 'Credit Card',
      cardNumber: '*2757',
      amount: -20
    },
    {
      service: 'Shopping',
      icon: 'uil-shopping-bag',
      date: '21.11.2024',
      cardImage: 'visa.png',
      cardType: 'Credit Card',
      cardNumber: '*1920',
      amount: -799
    },
    {
      service: 'Restaurant',
      icon: 'uil-restaurant',
      date: '19.11.2024',
      cardImage: 'master card.png',
      cardType: 'Master Card',
      cardNumber: '*8273',
      amount: -50
    },
    {
      service: 'Games',
      icon: 'uil-table-tennis',
      date: '15.11.2024',
      cardImage: 'visa.png',
      cardType: 'Credit Card',
      cardNumber: '*2757',
      amount: -44
    },
    {
      service: 'Pharmacy',
      icon: 'uil-flask',
      date: '15.11.2024',
      cardImage: 'visa.png',
      cardType: 'Credit Card',
      cardNumber: '*1920',
      amount: -30
    },
    {
      service: 'Fitness',
      icon: 'uil-dumbbell',
      date: '12.11.2021',
      cardImage: 'master card.png',
      cardType: 'Master Card',
      cardNumber: '*8273',
      amount: -45
    }
  ];

  getTransactions(): Transaction[] {
    return this.transactions;
  }
}
