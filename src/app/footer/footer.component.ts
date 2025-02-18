import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { UsefulLink } from '../Models/usefulLink.model';
import { OurService } from '../Models/OurService.model';
import { Socialink } from '../Models/SocialLink.model';

@Component({
  selector: 'app-footer',
  standalone: true,
  imports: [NgFor],
  templateUrl: './footer.component.html',
  styleUrl: './footer.component.css'
})
export class FooterComponent {
  usefulLinks: UsefulLink[] = [
    new UsefulLink('Home', '/home'),
    new UsefulLink('About Us', '/about'),
    new UsefulLink('Services', '/services'),
    new UsefulLink('Contact', '/contact')
  ];



  ourServices:OurService[] = [
  new OurService  ('Web Design', '#' ),
  new OurService ('Web Development',  '#' ),
    new OurService (  'Product Management',  '#' ),
      new OurService(  'Marketing',  '#' ),
      new OurService(  'Graphic Design',  '#' )
  ];
  socialLinks:Socialink[] = [
  new Socialink( 'Twitter',  '#',  'bx bxl-twitter' ),
  new Socialink ( 'Facebook', '#',  'bx bxl-facebook' ),
    new Socialink ( 'Instagram', '#',  'bx bxl-instagram' ),
    new Socialink( 'Skype', '#', 'bx bxl-skype' ),
    new Socialink( 'LinkedIn', '#',  'bx bxl-linkedin' )
  ];
}
