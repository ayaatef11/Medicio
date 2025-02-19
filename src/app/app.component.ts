import { Component,OnInit,HostListener } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { HeaderComponent } from "./header/header.component";

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [ HeaderComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
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

// Function to scroll smoothly to a target element
 scrollto = (el: string): void => {
  const header = this.select("#header") as HTMLElement | null;
  if (!header) return; // Exit if the header is not found

  const offset = header.offsetHeight; // Gets the header height
  const targetElement = this.select(el) as HTMLElement | null;
  if (!targetElement) return; // Exit if the target element is not found

  const elementPos = targetElement.offsetTop;

  window.scrollTo({
    top: elementPos - offset,
    behavior: "smooth",
  });
};


  selectHeader: HTMLElement | null = null;
  selectTopbar: HTMLElement | null = null;

  ngOnInit(): void {
    this.selectHeader = document.querySelector('#header');
    this.selectTopbar = document.querySelector('#topbar');
    this.headerScrolled(); // التحقق عند تحميل الصفحة
  }

  @HostListener('window:scroll', [])
  headerScrolled(): void {
    if (!this.selectHeader) return;

    if (window.scrollY > 100) {
      this.selectHeader.classList.add('header-scrolled');
      if (this.selectTopbar) {
        this.selectTopbar.classList.add('topbar-scrolled');
      }
    } else {
      this.selectHeader.classList.remove('header-scrolled');
      if (this.selectTopbar) {
        this.selectTopbar.classList.remove('topbar-scrolled');
      }
    }
  }



}
