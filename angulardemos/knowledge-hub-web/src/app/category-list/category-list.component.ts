import { Component, inject, OnInit } from '@angular/core';
import { Category } from '../../models/category';
import { CategoryService } from '../services/category.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-category-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './category-list.component.html',
  styleUrl: './category-list.component.css'
})
export class CategoryListComponent implements OnInit{
private categoryService:CategoryService = inject(CategoryService);
categoryList:Category[] = [];

  ngOnInit(): void {
    this.categoryService.getCategories().subscribe(res => 
      {
        this.categoryList = res;
      });
  }

}
