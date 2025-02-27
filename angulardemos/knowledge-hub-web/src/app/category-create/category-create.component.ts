import { Component, inject } from '@angular/core';
import { Category } from '../../models/category';
import { FormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';
import { CategoryService } from '../services/category.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-category-create',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './category-create.component.html',
  styleUrl: './category-create.component.css'
})
export class CategoryCreateComponent {
//private httpClient:HttpClient=null;

// constructor(private httpClient:HttpClient )
// {
// //this.httpClient = http;
// }
//private httpClient:HttpClient = inject(HttpClient);
private categoryService:CategoryService = inject(CategoryService)

  onSubmit() 
{
 //localStorage.setItem('category', JSON.stringify(this.category))
  // JSON Server
//http:HttpClient = new HttpClient();
this.categoryService.createCategory(this.category).subscribe(res => 
  {
    alert('Category created successfully');
  }, error => 
  {
    alert('Failed to create category: ' + error.message);
  });



console.log(this.category);


alert('Category posted successfully...')
//
//
}

category:Category=
{
  Name:'',
  Description:''
}

}
