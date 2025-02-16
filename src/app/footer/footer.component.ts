import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [NgFor],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css'
})
export class FooterComponent {
  usefulLinks = [
    { name: 'Home', url: '#' },
    { name: 'About us', url: '#' },
    { name: 'Services', url: '#' },
    { name: 'Terms of service', url: '#' },
    { name: 'Privacy policy', url: '#' }
  ];

  ourServices = [
    { name: 'Web Design', url: '#' },
    { name: 'Web Development', url: '#' },
    { name: 'Product Management', url: '#' },
    { name: 'Marketing', url: '#' },
    { name: 'Graphic Design', url: '#' }
  ];
  socialLinks = [
    { name: 'Twitter', url: '#', icon: 'bx bxl-twitter' },
    { name: 'Facebook', url: '#', icon: 'bx bxl-facebook' },
    { name: 'Instagram', url: '#', icon: 'bx bxl-instagram' },
    { name: 'Skype', url: '#', icon: 'bx bxl-skype' },
    { name: 'LinkedIn', url: '#', icon: 'bx bxl-linkedin' }
  ];
}
