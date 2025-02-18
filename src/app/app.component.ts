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

   on = (type:string, el:string, listener:EventListener, all:boolean = false) => {
    let selectEl = this.select(el, all)
    if (selectEl) {
      if (Array.isArray(selectEl)) {
        selectEl.forEach(e => e.addEventListener(type, listener))
      } else {
        selectEl.addEventListener(type, listener)
      }
    }
  }






}
