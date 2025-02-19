import { NgClass, NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { Slide } from '../Models/Slide.model';

@Component({
  selector: 'app-hero',
  standalone: true,
  imports: [NgFor,NgClass],
  templateUrl: './hero.component.html',
  styleUrl: './hero.component.css'
})
export class HeroComponent {
  slides: Slide[] = [
    new Slide('/img/slide/slide-1.jpg',
              'Welcome to <span>Medicio</span>',
              'Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel.',
              '#about'),
    new Slide('/img/slide/slide-2.jpg',
              'Lorem Ipsum Dolor',
              'Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel.',
              '#about'),
    new Slide('/img/slide/slide-3.jpg',
              'Sequi ea ut et est quaerat',
              'Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel.',
              '#about')
  ];

}
