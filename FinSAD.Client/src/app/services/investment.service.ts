import { Injectable } from '@angular/core';
import { Investment } from '../models/Investment';

@Injectable({
  providedIn: 'root'
})
export class InvestmentService {
  getInvestments(): Investment[] {
    return [
      {
        company: 'Uniliver',
        logo: 'uniliver.png',
        date: '7 Nov, 2021',
        time: '9:14 pm',
        bonds: 1243,
        amount: 20324,
        change: -4.27
      },
      {
        company: 'Tesla',
        logo: 'tesla.png',
        date: '1 Dec, 2021',
        time: '11:54 pm',
        bonds: 5477,
        amount: 720111,
        change: 38.67
      },
      {
        company: 'Monster',
        logo: 'monster.png',
        date: '1 Dec, 2021',
        time: '4:02 pm',
        bonds: 700,
        amount: 13301,
        change: 7.27
      },
      {
        company: 'McDonalds',
        logo: 'mcdonalds.png',
        date: '3 Dec, 2021',
        time: '8:17 pm',
        bonds: 5200,
        amount: 78030,
        change: -1.02
      }
    ];
  }
}
