import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-features',
  standalone: true,
  imports: [NgFor],
  templateUrl: './features.component.html',
  styleUrl: './features.component.css'
})
export class FeaturesComponent {
  socialLinks = [
    { name: 'Twitter', url: '#', icon: 'bx bxl-twitter' },
    { name: 'Facebook', url: '#', icon: 'bx bxl-facebook' },
    { name: 'Instagram', url: '#', icon: 'bx bxl-instagram' },
    { name: 'Skype', url: '#', icon: 'bx bxl-skype' },
    { name: 'LinkedIn', url: '#', icon: 'bx bxl-linkedin' }
  ];
}
