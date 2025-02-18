import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./header/header.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ HeaderComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'Medicio';

    select = (el:string, all:boolean = false):HTMLElement | HTMLElement[] | null=> {
    el = el.trim()
    if (all) {
      return Array.from(document.querySelectorAll(el) )as HTMLElement[];//return all elements that are identicalto el
    } else {
      return document.querySelector(el)  as HTMLElement | null;
    }
  }
}
