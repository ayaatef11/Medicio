import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { UsefulLink } from '../../../Models/usefulLink.model';
import { OurService } from '../../../Models/OurService.model';
import { SocialLink } from '../../../Models/SocialLink.model';
import { RouterLink } from '@angular/router';

@Component({
  standalone:true,
    selector: 'app-footer',
    imports: [CommonModule,RouterLink], // Ensure CommonModule is imported
    templateUrl: './footer.component.html',
    styleUrls: ['./footer.component.css']
})
export class FooterComponent {
  usefulLinks: UsefulLink[] = [
    new UsefulLink('Home', '/home'),
    new UsefulLink('About us', '/about'),
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
    new SocialLink('Twitter', 'https://twitter.com/', 'bx bxl-twitter'),
    new SocialLink('Facebook', 'https://www.facebook.com/', 'bx bxl-facebook'),
    new SocialLink('Instagram', 'https://www.instagram.com/', 'bx bxl-instagram'),
    new SocialLink('LinkedIn', 'https://www.linkedin.com/', 'bx bxl-linkedin')
  ];
  subscribe(){
    console.log('success');
  }
}
