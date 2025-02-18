import { Component } from '@angular/core';
import { CountBox } from '../Models/CountBox.model';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-counts',
  standalone: true,
  imports: [NgFor],
  templateUrl: './counts.component.html',
  styleUrl: './counts.component.css'
})
export class CountsComponent {
  countBoxes: CountBox[] = [
    new CountBox('fas fa-user-md', 85, 'Doctors', 'consequuntur quae qui deca rode', '#'),
    new CountBox('far fa-hospital', 26, 'Departments', 'adipisci atque cum quia aut numquam delectus', '#'),
    new CountBox('fas fa-flask', 14, 'Research Lab', 'aut commodi quaerat. Aliquam ratione', '#'),
    new CountBox('fas fa-award', 150, 'Awards', 'rerum asperiores dolor molestiae doloribu', '#')
  ];
}
