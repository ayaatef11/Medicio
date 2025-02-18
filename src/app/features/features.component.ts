import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { Socialink } from '../Models/SocialLink.model';

@Component({
  selector: 'app-features',
  standalone: true,
  imports: [NgFor],
  templateUrl: './features.component.html',
  styleUrl: './features.component.css'
})
export class FeaturesComponent {
  socialLinks:Socialink[] = [
  new Socialink( 'Twitter',  '#',  'bx bxl-twitter' ),
  new Socialink ( 'Facebook', '#',  'bx bxl-facebook' ),
    new Socialink ( 'Instagram', '#',  'bx bxl-instagram' ),
    new Socialink( 'Skype', '#', 'bx bxl-skype' ),
    new Socialink( 'LinkedIn', '#',  'bx bxl-linkedin' )
  ];
}
