import { Component } from '@angular/core';
import { FrequentQuestionsComponent } from "../../frequent-questions/frequent-questions.component";
import { TestimonialsComponent } from "../../testimonials/testimonials.component";

@Component({
  standalone:true,
  selector: 'app-about',
    imports: [ TestimonialsComponent],
    templateUrl: './about.component.html',
    styleUrl: './about.component.css'
})
export class AboutComponent {

}
