import { Component } from '@angular/core';
import { InvestmentService } from '../../services/investment.service';
import { Investment } from '../../models/Investment';
import { CommonModule, NgClass, NgFor } from '@angular/common';

@Component({
  selector: 'app-investments',
  imports: [NgFor, NgClass, CommonModule],
  templateUrl: './investments.component.html',
  styleUrls: ['./investments.component.css']
})
export class InvestmentsComponent {
  investments: Investment[] = [];

  constructor(private investmentService: InvestmentService) {
    this.investments = this.investmentService.getInvestments();
  }

  getChangeClass(change: number): string {
    return change < 0 ? 'danger' : 'success';
  }
}
