import { Component } from '@angular/core';
import { CardsComponent } from "../../components/cards/cards.component";
import { FastPaymentComponent } from "../../components/fast-payment/fast-payment.component";
import { DashboardChartComponent } from "../../components/dashboard-chart/dashboard-chart.component";
import { InvestmentsComponent } from "../../components/investments/investments.component";
import { RecentTransactionsComponent } from "../../components/recent-transactions/recent-transactions.component";

@Component({
  selector: 'app-dashboard',
  imports: [ CardsComponent, FastPaymentComponent, DashboardChartComponent, InvestmentsComponent, RecentTransactionsComponent],
  templateUrl: './dashboard.component.html',
  styleUrl: './dashboard.component.css'
})
export class DashboardComponent {

}
