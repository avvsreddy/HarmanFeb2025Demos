import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TitleComponent } from "./title/title.component";
import { NavBarComponent } from "./nav-bar/nav-bar.component";
import { HomeComponent } from "./home/home.component";
import { FooterComponent } from "./footer/footer.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, TitleComponent, NavBarComponent, HomeComponent, FooterComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'knowledge-hub-web';
}
