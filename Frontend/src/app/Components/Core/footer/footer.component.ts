import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { UsefulLink } from '../../../Models/usefulLink.model';
import { OurService } from '../../../Models/OurService.model';
import { SocialLink } from '../../../Models/SocialLink.model';
import { RouterLink } from '@angular/router';

@Component({
  standalone:true,
    selector: 'app-footer',
    imports: [CommonModule], // Ensure CommonModule is imported
    templateUrl: './footer.component.html',
    styleUrls: ['./footer.component.css']
})
export class FooterComponent {

  ourServices: OurService[] = [
    new OurService('Web Design', '#'),
    new OurService('Web Development', '#'),
    new OurService('Product Management', '#'),
    new OurService('Marketing', '#'),
    new OurService('Graphic Design', '#')
  ];

  subscribe(){
    console.log('success');
  }
}
