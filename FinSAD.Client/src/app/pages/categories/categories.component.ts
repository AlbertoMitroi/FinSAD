import { Component, OnInit } from '@angular/core';
import {CommonModule} from '@angular/common';
import { CategoryCardComponent } from '../../components/category-card/category-card.component';
import {CategoryService} from '../../services/category.service'
import { CategoryModel } from '../../models/Category'

@Component({
  selector: 'app-categories',
  imports: [CommonModule, CategoryCardComponent],
  templateUrl: './categories.component.html',
  styleUrl: './categories.component.css'
})
export class CategoriesComponent implements OnInit {
  categories: CategoryModel[] = [];
    notFound = false; // Add this flag
  constructor(private categoriesService: CategoryService) {}
   ngOnInit(): void {
    this.categoriesService.getCategories().subscribe({
      next: (data) => {
        this.categories = data;
        this.notFound = false;
      },
      error: (err) => {
        if (err.status === 404) {
          this.notFound = true;
        }
        // console.error('Failed to fetch categories:', err);
      }
    })
  }
   trackByFn(index: number, item: CategoryModel): number {
    return index;
  }
}
