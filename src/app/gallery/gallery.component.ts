import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-gallery',
  standalone: true,
  imports: [NgFor],
  templateUrl: './gallery.component.html',
  styleUrl: './gallery.component.css'
})
export class GalleryComponent {
  galleryImages = [
    { src: '/img/gallery/gallery-1.jpg' },
    { src: '/img/gallery/gallery-2.jpg' },
    { src: '/img/gallery/gallery-3.jpg' },
    { src: '/img/gallery/gallery-4.jpg' },
    { src: '/img/gallery/gallery-5.jpg' },
    { src: '/img/gallery/gallery-6.jpg' },
    { src: '/img/gallery/gallery-7.jpg' },
    { src: '/img/gallery/gallery-8.jpg' }
  ];
}
