import { Component, OnInit, Renderer2 } from '@angular/core';
import { AuthService } from '../../services/auth.service'; 
import { NgClass, NgIf } from '@angular/common';

@Component({
  selector: 'app-navbar',
  imports: [NgClass, NgIf],
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  isDarkTheme = false;
  userName: string = '';
  dropdownOpen = false;

  constructor(private renderer: Renderer2, private authService: AuthService) {}

  ngOnInit(): void {
    const savedTheme = localStorage.getItem('theme');
    this.isDarkTheme = savedTheme === 'dark';
    this.updateThemeClass();

    
    const user = localStorage.getItem('name');  
    this.userName = user ? user : 'Utilizator';
  }

  toggleTheme(): void {
    this.isDarkTheme = !this.isDarkTheme;
    localStorage.setItem('theme', this.isDarkTheme ? 'dark' : 'light');
    this.updateThemeClass();
  }

  toggleDropdown(): void {
    this.dropdownOpen = !this.dropdownOpen;
  }

  logout(): void {
    this.authService.logout();
    this.dropdownOpen = false;
  }

  private updateThemeClass(): void {
    if (this.isDarkTheme) {
      this.renderer.addClass(document.body, 'dark-theme');
    } else {
      this.renderer.removeClass(document.body, 'dark-theme');
    }
  }
}
