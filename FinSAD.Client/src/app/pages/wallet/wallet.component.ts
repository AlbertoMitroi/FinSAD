import { Component } from '@angular/core';
import { NavbarComponent } from "../../components/navbar/navbar.component";
import { SidebarComponent } from "../../components/sidebar/sidebar.component";
import { WalletMainComponent } from "../../components/wallet-main/wallet-main.component";

@Component({
  selector: 'app-wallet',
  imports: [NavbarComponent, SidebarComponent, WalletMainComponent],
  templateUrl: './wallet.component.html',
  styleUrl: './wallet.component.css'
})
export class WalletComponent {

}
