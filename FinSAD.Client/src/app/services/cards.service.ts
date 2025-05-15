import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { CardModel } from '../models/CardModels';
import { AuthService } from './auth.service';

@Injectable({
  providedIn: 'root'
})
export class CardsService {
  private baseUrl = 'https://localhost:7283/api/Card';

  constructor(private http: HttpClient, private authService: AuthService) {}

  getCards(): Observable<CardModel[]> {
    const token = this.authService.getToken();

    const headers = new HttpHeaders({
      Authorization: `Bearer ${token}`
    });

    return this.http.get<CardModel[]>(`${this.baseUrl}/user/1`, { headers });
  }
}
