import { Component, Input, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CategoryModel } from '../../models/Category';

@Component({
  selector: 'category-card',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './category-card.component.html',
  styleUrls: ['./category-card.component.css']
})
export class CategoryCardComponent implements OnInit {
  @Input() category!: CategoryModel;

  ngOnInit(): void {
    // Optional: any init logic
  }
}
