import { Injectable } from '@angular/core';
import {CategoryModel} from '../models/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {
  getCategories(): CategoryModel[] {
    return [
      {
        title: 'Food',
        description:'I like to eat a lot',
      },
      {
        title: 'Gym',
        description:'I like to exercise a lot',
      },
    ];
  }
}
