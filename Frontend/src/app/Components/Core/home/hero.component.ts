import { NgClass, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';
import { Slide } from '../../../Models/Slide.model';
import { GalleryComponent } from "../../gallery/gallery.component";

@Component({
  imports: [NgFor, NgClass, RouterLink, GalleryComponent],
  standalone:true,
    selector: 'app-hero',

    templateUrl: './hero.component.html',
    styleUrl: './hero.component.css'
})
export class HeroComponent {
  slides: Slide[] = [
    new Slide('/img/slide/slide-1.jpg',
              'Welcome to <span>Medicio</span>',
              'Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel.',
              '#about')
  ];

}
