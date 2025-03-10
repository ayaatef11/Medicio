import { Component } from '@angular/core';
import { Service } from '../Models/Service.model';
import { NgFor } from '@angular/common';

@Component({
    selector: 'app-services',
    imports: [NgFor],
    templateUrl: './services.component.html',
    styleUrl: './services.component.css'
})
export class ServicesComponent {
  services: Service[] = [
    new Service("fas fa-heartbeat", "Lorem Ipsum", "Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident", 100),
    new Service("fas fa-pills", "Dolor Sitema", "Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata", 200),
    new Service("fas fa-hospital-user", "Sed ut perspiciatis", "Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur", 300),
    new Service("fas fa-dna", "Magni Dolores", "Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum", 100),
    new Service("fas fa-wheelchair", "Nemo Enim", "At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis praesentium voluptatum deleniti atque", 200),
    new Service("fas fa-notes-medical", "Eiusmod Tempor", "Et harum quidem rerum facilis est et expedita distinctio. Nam libero tempore, cum soluta nobis est eligendi", 300)
  ];
}
