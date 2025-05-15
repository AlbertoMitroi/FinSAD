import { Routes } from '@angular/router';
import { DashboardComponent } from '../pages/dashboard/dashboard.component';
//import { LoginComponent } from './components/login/login.component';
//import { RegisterComponent } from './components/register/register.component';
//import { AuthGuard } from './guards/auth.guard';
import { WalletComponent } from '../pages/wallet/wallet.component';
import { TransactionsComponent } from '../pages/transactions/transactions.component';
import { CategoriesComponent } from '../pages/categories/categories.component';
import { AuthGuard } from '../guards/auth.guard';

export const routes: Routes = [
  //{ path: 'login', component: LoginComponent },
  //{ path: 'register', component: RegisterComponent },
  { path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuard] },
  { path: 'wallet', component: WalletComponent, canActivate: [AuthGuard] },
  { path: 'transactions', component: TransactionsComponent, canActivate: [AuthGuard] },
  { path: 'categories', component: CategoriesComponent, canActivate: [AuthGuard] },
  //{ path: '', redirectTo: 'login', pathMatch: 'full' },
  //{ path: '**', redirectTo: 'login' },
];
