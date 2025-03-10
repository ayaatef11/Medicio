import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { Doctor } from '../../../Models/Doctor.model';

@Component({
  standalone:true,
  selector: 'app-doctors',
    imports: [NgFor],
    templateUrl: './doctors.component.html',
    styleUrl: './doctors.component.css'
})
export class DoctorsComponent {
  doctors: Doctor[] = [
    new Doctor("Walter White", "Chief Medical Officer", "/img/doctors/doctors-1.jpg", [
      { icon: "bi bi-twitter", url: "#" },
      { icon: "bi bi-facebook", url: "#" },
      { icon: "bi bi-instagram", url: "#" },
      { icon: "bi bi-linkedin", url: "#" }
    ]),
    new Doctor("Sarah Johnson", "Anesthesiologist", "/img/doctors/doctors-2.jpg", [
      { icon: "bi bi-twitter", url: "#" },
      { icon: "bi bi-facebook", url: "#" },
      { icon: "bi bi-instagram", url: "#" },
      { icon: "bi bi-linkedin", url: "#" }
    ])
  ];
}
