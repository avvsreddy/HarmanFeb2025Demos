import { Component } from '@angular/core';
import { Category } from '../../models/category';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-category-create',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './category-create.component.html',
  styleUrl: './category-create.component.css'
})
export class CategoryCreateComponent {
onSubmit() 
{
 localStorage.setItem('category', JSON.stringify(this.category))
  
}

category:Category=
{
  title:'',
  description:''
}

}
