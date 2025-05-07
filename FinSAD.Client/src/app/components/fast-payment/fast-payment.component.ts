import { Component } from '@angular/core';
import { FastPaymentService } from '../../services/fast-payment.service';
import { FastPaymentItem } from '../../models/FastPaymentItem';
import { NgClass, NgFor } from '@angular/common';

@Component({
  selector: 'app-fast-payment',
  imports: [NgClass, NgFor],
  templateUrl: './fast-payment.component.html',
  styleUrls: ['./fast-payment.component.css']
})
export class FastPaymentComponent {
  payments: FastPaymentItem[] = [];

  constructor(private fastPaymentService: FastPaymentService) {
    this.payments = this.fastPaymentService.getPayments();
  }
}
