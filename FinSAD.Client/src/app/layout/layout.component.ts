import { Component } from '@angular/core';
import { NavbarComponent } from "./navbar/navbar.component";
import { SidebarComponent } from "./sidebar/sidebar.component";
import { RouterOutlet } from '@angular/router';

//import { CardsComponent } from "../../components/cards/cards.component";
//import { FastPaymentComponent } from "../../components/fast-payment/fast-payment.component";
//import { DashboardChartComponent } from "../../components/dashboard-chart/dashboard-chart.component";
//import { InvestmentsComponent } from "../../components/investments/investments.component";
//import { RecentTransactionsComponent } from "../../components/recent-transactions/recent-transactions.component";

@Component({
  selector: 'app-layout',
  imports: [NavbarComponent, SidebarComponent, RouterOutlet],
  templateUrl: './layout.component.html',
  styleUrl: './layout.component.css'
})
export class LayoutComponent {

}
