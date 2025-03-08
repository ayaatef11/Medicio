import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { UsefulLink } from '../Models/usefulLink.model';
import { OurService } from '../Models/OurService.model';
import { SocialLink } from '../Models/SocialLink.model';

@Component({
    selector: 'app-footer',
    imports: [CommonModule], // Ensure CommonModule is imported
    templateUrl: './footer.component.html',
    styleUrls: ['./footer.component.css']
})
export class FooterComponent {
  usefulLinks: UsefulLink[] = [
    new UsefulLink('Home', '/home'),
    new UsefulLink('About Us', '/about'),
    new UsefulLink('Services', '/services'),
    new UsefulLink('Contact', '/contact')
  ];

  ourServices: OurService[] = [
    new OurService('Web Design', '#'),
    new OurService('Web Development', '#'),
    new OurService('Product Management', '#'),
    new OurService('Marketing', '#'),
    new OurService('Graphic Design', '#')
  ];

  socialLinks: SocialLink[] = [
    new SocialLink('Twitter', '#', 'bx bxl-twitter'),
    new SocialLink('Facebook', '#', 'bx bxl-facebook'),
    new SocialLink('Instagram', '#', 'bx bxl-instagram'),
    new SocialLink('Skype', '#', 'bx bxl-skype'),
    new SocialLink('LinkedIn', '#', 'bx bxl-linkedin')
  ];
}
