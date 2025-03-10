import { Component,OnInit,HostListener } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { FooterComponent } from './Components/Core/footer/footer.component';
import { HeaderComponent } from './Components/Core/header/header.component';
import { DoctorsComponent } from "./Components/Core/doctors/doctors.component";



@Component({
  selector: 'app-root',
  standalone: true,
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  imports: [HeaderComponent, FooterComponent, RouterOutlet, RouterModule]
})
export class AppComponent {
  title = 'Medicio';

}
