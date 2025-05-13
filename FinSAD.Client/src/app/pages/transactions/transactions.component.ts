import { Component } from '@angular/core';
import { NavbarComponent } from "../../components/navbar/navbar.component";
import { SidebarComponent } from "../../components/sidebar/sidebar.component";
import { TransactionsMainComponent } from "../../components/transactions-main/transactions-main.component";

@Component({
  selector: 'app-transactions',
  imports: [NavbarComponent, SidebarComponent, TransactionsMainComponent],
  templateUrl: './transactions.component.html',
  styleUrl: './transactions.component.css'
})
export class TransactionsComponent {

}
