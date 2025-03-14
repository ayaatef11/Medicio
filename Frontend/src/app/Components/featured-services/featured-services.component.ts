import { Component } from '@angular/core';
import { NgFor } from '@angular/common';
import { IconBox } from '../../Models/IconBox.model';

@Component({
  standalone:true,
  selector: 'app-featured-services',
    imports: [NgFor],
    templateUrl: './featured-services.component.html',
    styleUrl: './featured-services.component.css'
})
export class FeaturedServicesComponent {
  iconBoxes: IconBox[] = [
    new IconBox('fas fa-heartbeat', 'Lorem Ipsum', 'Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi', 100),
    new IconBox('fas fa-pills', 'Sed ut perspiciatis', 'Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore', 200),
    new IconBox('fas fa-thermometer', 'Magni Dolores', 'Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia', 300),
    new IconBox('fas fa-dna', 'Nemo Enim', 'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis', 400)
  ];
}
