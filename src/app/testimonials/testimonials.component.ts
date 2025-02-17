import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { Testimonial } from '../Models/Testimonial.model';

@Component({
  selector: 'app-testimonials',
  standalone: true,
  imports: [NgFor],
  templateUrl: './testimonials.component.html',
  styleUrl: './testimonials.component.css'
})
export class TestimonialsComponent {
  testimonials: Testimonial[] = [
    new Testimonial(
      "Proin iaculis purus consequat sem cure digni ssim donec porttitora entum suscipit rhoncus. Accusantium quam, ultricies eget id, aliquam eget nibh et. Maecen aliquam, risus at semper.",
      "assets/img/testimonials/testimonials-1.jpg",
      "Saul Goodman",
      "Ceo & Founder"
    ),
    new Testimonial(
      "Export tempor illum tamen malis malis eram quae irure esse labore quem cillum quid cillum eram malis quorum velit fore eram velit sunt aliqua noster fugiat irure amet legam anim culpa.",
      "assets/img/testimonials/testimonials-2.jpg",
      "Sara Wilsson",
      "Designer"
    ),
    new Testimonial(
      "Enim nisi quem export duis labore cillum quae magna enim sint quorum nulla quem veniam duis minim tempor labore quem eram duis noster aute amet eram fore quis sint minim.",
      "assets/img/testimonials/testimonials-3.jpg",
      "Jena Karlis",
      "Store Owner"
    ),
    new Testimonial(
      "Fugiat enim eram quae cillum dolore dolor amet nulla culpa multos export minim fugiat minim velit minim dolor enim duis veniam ipsum anim magna sunt elit fore quem dolore labore illum veniam.",
      "assets/img/testimonials/testimonials-4.jpg",
      "Matt Brandon",
      "Freelancer"
    ),
    new Testimonial(
      "Quis quorum aliqua sint quem legam fore sunt eram irure aliqua veniam tempor noster veniam enim culpa labore duis sunt culpa nulla illum cillum fugiat legam esse veniam culpa fore nisi cillum quid.",
      "assets/img/testimonials/testimonials-5.jpg",
      "John Larson",
      "Entrepreneur"
    )
  ];
}
