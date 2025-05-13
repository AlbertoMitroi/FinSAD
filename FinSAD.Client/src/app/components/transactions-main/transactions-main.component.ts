import { NgClass, NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-transactions-main',
  imports: [NgClass, NgFor],
  templateUrl: './transactions-main.component.html',
  styleUrl: './transactions-main.component.css'
})
export class TransactionsMainComponent {
transactions = [
  {
    id: '#5254645643523423',
    date: '23/09/2023',
    from: 'Alberto',
    to: 'Dragos',
    coin: 'USD',
    amount: 1000,
    note: 'Payment for a cigarette',
    status: 'Completed',
    statusClass: 'success'
  },
  {
    id: '#5254645643523424',
    date: '24/09/2023',
    from: 'Alberto',
    to: 'Sabin',
    coin: 'EUR',
    amount: 500,
    note: 'Payment for dinner',
    status: 'Pending',
    statusClass: 'warning'
  },
  {
    id: '#5254645643523425',
    date: '25/09/2023',
    from: 'Dragos',
    to: 'Alberto',
    coin: 'USD',
    amount: 2000,
    note: 'Refund for overpayment',
    status: 'Completed',
    statusClass: 'success'
  },
  {
    id: '#5254645643523426',
    date: '26/09/2023',
    from: 'Alberto',
    to: 'Dragos',
    coin: 'GBP',
    amount: 1200,
    note: 'Payment for service',
    status: 'Completed',
    statusClass: 'success'
  },
  {
    id: '#5254645643523427',
    date: '27/09/2023',
    from: 'Sabin',
    to: 'Alberto',
    coin: 'USD',
    amount: 700,
    note: 'Loan repayment',
    status: 'Completed',
    statusClass: 'success'
  },
  {
    id: '#5254645643523428',
    date: '28/09/2023',
    from: 'Alberto',
    to: 'Sabin',
    coin: 'USD',
    amount: 1500,
    note: 'Payment for project',
    status: 'Pending',
    statusClass: 'warning'
  },
  {
    id: '#5254645643523429',
    date: '29/09/2023',
    from: 'Dragos',
    to: 'Alberto',
    coin: 'EUR',
    amount: 400,
    note: 'Gift for birthday',
    status: 'Completed',
    statusClass: 'success'
  },
  {
    id: '#5254645643523430',
    date: '30/09/2023',
    from: 'Alberto',
    to: 'Dragos',
    coin: 'USD',
    amount: 600,
    note: 'Payment for lunch',
    status: 'Failed',
    statusClass: 'danger'
  },
  {
    id: '#5254645643523431',
    date: '01/10/2023',
    from: 'Sabin',
    to: 'Alberto',
    coin: 'USD',
    amount: 200,
    note: 'Repayment for taxi ride',
    status: 'Completed',
    statusClass: 'success'
  },
  {
    id: '#5254645643523432',
    date: '02/10/2023',
    from: 'Alberto',
    to: 'Dragos',
    coin: 'EUR',
    amount: 800,
    note: 'Payment for supplies',
    status: 'Pending',
    statusClass: 'warning'
  }
];
}