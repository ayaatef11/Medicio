import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { SocialLink } from '../Models/SocialLink.model';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-features',
  standalone: true,
  imports: [RouterLink,NgFor],
  templateUrl: './features.component.html',
  styleUrl: './features.component.css'
})
export class FeaturesComponent {
  socialLinks:SocialLink[] = [
  new SocialLink( 'Twitter',  '#',  'bx bxl-twitter' ),
  new SocialLink ( 'Facebook', '#',  'bx bxl-facebook' ),
    new SocialLink ( 'Instagram', '#',  'bx bxl-instagram' ),
    new SocialLink( 'Skype', '#', 'bx bxl-skype' ),
    new SocialLink( 'LinkedIn', '#',  'bx bxl-linkedin' )
  ];
}
