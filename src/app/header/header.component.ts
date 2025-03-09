import { Component, HostListener, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
    standalone:true,
    selector: 'app-header',
    templateUrl: './header.component.html',
    styleUrls: ['./header.component.css'],
    imports: [CommonModule, RouterLink]
})
export class HeaderComponent{//} implements OnInit {
  navbar!: HTMLElement | null;
  mobileNavToggle!: HTMLElement | null;

  // ngOnInit(): void {
  //   this.navbar = document.querySelector('#navbar');
  //   this.mobileNavToggle = document.querySelector('.mobile-nav-toggle');
  //   this.setupEventListeners();
  // }

  // setupEventListeners(): void {
  //   document.querySelector('.mobile-nav-toggle')?.addEventListener('click', () => {
  //     this.toggleMobileMenu();
  //   });

  //   document.querySelectorAll('.navbar .dropdown > a').forEach((dropdown) => {
  //     dropdown.addEventListener('click', (event) => this.toggleDropdown(event, dropdown as HTMLAnchorElement));
  //   });

  //   document.querySelectorAll('.scrollto').forEach((link) => {
  //     link.addEventListener('click', (event) => this.scrollToSection(event, link as HTMLAnchorElement));
  //   });
  // }

  // toggleMobileMenu(): void {
  //   if (!this.navbar || !this.mobileNavToggle) return;

  //   this.navbar.classList.toggle('navbar-mobile');
  //   this.mobileNavToggle.classList.toggle('bi-list');
  //   this.mobileNavToggle.classList.toggle('bi-x');
  // }

  // toggleDropdown(event: Event, element: HTMLAnchorElement): void {
  //   if (this.navbar?.classList.contains('navbar-mobile')) {
  //     event.preventDefault();
  //     element.nextElementSibling?.classList.toggle('dropdown-active');
  //   }
  // }

  // scrollToSection(event: Event, element: HTMLAnchorElement): void {
  //   if (!element.hash) return;

  //   const targetElement = document.querySelector(element.hash) as HTMLElement | null;
  //   if (targetElement) {
  //     event.preventDefault();

  //     if (this.navbar?.classList.contains('navbar-mobile')) {
  //       this.navbar.classList.remove('navbar-mobile');
  //       this.mobileNavToggle?.classList.toggle('bi-list');
  //       this.mobileNavToggle?.classList.toggle('bi-x');
  //     }

  //     window.scrollTo({
  //       top: targetElement.offsetTop - (this.navbar?.offsetHeight || 0),
  //       behavior: 'smooth'
  //     });
  //   }
  // }

  // @HostListener('window:scroll')
  // onWindowScroll(): void {
  //   if (window.scrollY > 100) {
  //     this.navbar?.classList.add('header-scrolled');
  //   } else {
  //     this.navbar?.classList.remove('header-scrolled');
  //   }
  // }
}
