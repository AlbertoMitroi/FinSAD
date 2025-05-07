import { Injectable } from '@angular/core';
import { CardModel } from '../models/CardModels';

@Injectable({
  providedIn: 'root'
})
export class CardsService {
  getCards(): CardModel[] {
    return [
      {
        currency: 'USD',
        amount: '$27,119',
        holder: 'Alberto Mitroi',
        expiry: '12/35',
        cvv: '**5',
        currencyLogo: 'USD.png',
        providerLogo: 'citigroup.png'
      },
      {
        currency: 'GBP',
        amount: '£12,102',
        holder: 'Alberto Mitroi',
        expiry: '08/30',
        cvv: '**9',
        currencyLogo: 'GBP.png',
        providerLogo: 'master card.png'
      },
      {
        currency: 'EURO',
        amount: '€7,382',
        holder: 'Alberto Mitroi',
        expiry: '06/26',
        cvv: '**2',
        currencyLogo: 'EURO.png',
        providerLogo: 'visa.png'
      }
    ];
  }
}
