import { Injectable } from '@angular/core';
import { FastPaymentItem } from '../models/FastPaymentItem';

@Injectable({
  providedIn: 'root'
})
export class FastPaymentService {
  getPayments(): FastPaymentItem[] {
    return [
      { category: 'Food', amount: 50, color: 'success' },
      { category: 'Internet', amount: 20, color: 'success' },
      { category: 'Gas', amount: 180, color: 'primary' },
      { category: 'Electricity', amount: 109, color: 'danger' },
      { category: 'Gaming', amount: 125, color: 'primary' },
      { category: 'Travels', amount: 765, color: 'danger' },
      { category: 'Education', amount: 1093, color: 'primary' },
      { category: 'Cinema', amount: 65, color: 'danger' }
    ];
  }
}
