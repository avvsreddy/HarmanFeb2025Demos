import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
@Component({
  selector: 'app-home',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {
data:string = "this is a sample dynamic data shown to paid users only";
isPaid:boolean=true;

articles:string[]=['Article 1', 'Article 2','Article 3'];
}
