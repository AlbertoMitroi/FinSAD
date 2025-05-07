import { Component, OnInit } from '@angular/core';
import { RecentTransactionsService } from '../../services/recent-transactions.service';
import { CommonModule, NgClass } from '@angular/common';
import { Transaction } from '../../models/Transaction';

@Component({
  selector: 'app-recent-transactions',
  imports: [CommonModule],
  templateUrl: './recent-transactions.component.html',
  styleUrls: ['./recent-transactions.component.css']
})
export class RecentTransactionsComponent implements OnInit {
  transactions: Transaction[] = [];

  constructor(private recentTransactionsService: RecentTransactionsService) {}

  ngOnInit(): void {
    this.transactions = this.recentTransactionsService.getTransactions();
  }
}
