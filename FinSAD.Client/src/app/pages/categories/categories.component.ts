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
  constructor(private categoriesService: CategoryService) {}
   ngOnInit(): void {
    this.categories = this.categoriesService.getCategories();
  }
   trackByFn(index: number, item: CategoryModel): number {
    return index;
  }
}
