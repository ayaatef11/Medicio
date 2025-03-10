import { CommonModule, NgFor } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Doctor } from '../../../Models/Doctor.model';
import { CtaComponent } from '../../cta/cta.component';
// import AOS from '../../../../assets/vendor/aos/aos.js';
@Component({

  selector: 'app-doctors',
  standalone:true,
    imports: [NgFor,CommonModule,CtaComponent],//ngfor needs common module to work but in modular way
    templateUrl: './doctors.component.html',
    styleUrls: ['./doctors.component.css']
})
export class DoctorsComponent implements OnInit {
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
  // /**
  //  *
  //  */
  // constructor() {
  //  this.doctors;

  // }
ngOnInit(): void {
    // AOS.init
}
}
