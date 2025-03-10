import { Component } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  standalone:true,
  selector: 'app-cta',
    imports: [RouterLink],
    templateUrl: './cta.component.html',
    styleUrl: './cta.component.css'
})
export class CtaComponent {

}
