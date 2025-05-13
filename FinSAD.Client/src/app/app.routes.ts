import { Routes } from '@angular/router';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { AuthGuard } from './guards/auth.guard';
import { WalletComponent } from './pages/wallet/wallet.component';
import { TransactionsComponent } from './pages/transactions/transactions.component';
import { LayoutComponent } from './layout/layout.component';

export const routes: Routes = [

  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
  //{ path: 'dashboard', component: DashboardComponent },
  //{ path: 'wallet', component: WalletComponent },
  //{ path: 'transactions', component: TransactionsComponent },
  { path: '', redirectTo: 'login', pathMatch: 'full' },

  {
    path: '',
    component: LayoutComponent, // Apply layout component as a wrapper
    children: [
      { path: '', redirectTo: 'dashboard', pathMatch: 'full' },
      { path: 'dashboard', component: DashboardComponent },
      { path: 'wallet', component: WalletComponent },
      { path: 'transactions', component: TransactionsComponent },
      // Add more routes that should use the main layout
    ]
  },
  { path: '**', redirectTo: 'login' },
];
