import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryCardComponent } from '../../components/category-card/category-card.component';
import { CategoryService } from '../../services/category.service';
import { CategoryModel } from '../../models/Category';
import { FormsModule } from '@angular/forms'; // <-- Import FormsModule

@Component({
  selector: 'app-categories',
  imports: [CommonModule, CategoryCardComponent, FormsModule],
  templateUrl: './categories.component.html',
  styleUrl: './categories.component.css'
})
export class CategoriesComponent implements OnInit {
  categories: CategoryModel[] = [];
  notFound = false;
  newCategory = { title: '', description: '' };
  showAddForm = false; // <-- Add this flag

  onShowAddForm() {
    this.showAddForm = true;
  }

  onCancelAdd() {
    this.showAddForm = false;
    this.newCategory = { title: '', description: '' };
  }
  constructor(private categoriesService: CategoryService) {}

  ngOnInit(): void {
    this.fetchCategories();
  }

  fetchCategories() {
    this.categoriesService.getCategories().subscribe({
      next: (data) => {
        this.categories = data;
        this.notFound = false;
      },
      error: (err) => {
        if (err.status === 404) {
          this.notFound = true;
        }
      }
    });
  }

  onAddCategory() {
    if (!this.newCategory.title || !this.newCategory.description) return;
    this.categoriesService.addCategory(this.newCategory).subscribe({
      next: (category) => {
        this.categories.push(category);
        this.notFound = false;
        this.newCategory = { title: '', description: '' };
      },
      error: (err) => {
        // Optionally handle error
      }
    });
  }

  trackByFn(index: number, item: CategoryModel): number {
    return index;
  }
}