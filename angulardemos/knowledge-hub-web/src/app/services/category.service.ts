import { inject, Injectable } from '@angular/core';
import { Category } from '../../models/category';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  
  //constructor(private httpClient:HttpClient) { }
  private httpClient:HttpClient = inject(HttpClient);

createCategory(category:Category)
{
  // post the category data to api
  return this.httpClient.post<Category>('http://localhost:3000/categories',category)
//.subscribe(res => {console.log(res)});
}

getCategories()
{
// fetch category data from api and return  
  return this.httpClient.get<Category[]>('http://localhost:3000/categories')
  
}

}
