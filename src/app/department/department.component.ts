import { NgFor } from '@angular/common';
import { Component } from '@angular/core';

@Component({
  selector: 'app-department',
  standalone: true,
  imports: [NgFor],
  templateUrl: './department.component.html',
  styleUrl: './department.component.css'
})
export class DepartmentComponent {
  departments = [
    { id: 'tab-1', name: 'Cardiology', description: 'Quis excepturi porro totam sint earum quo nulla perspiciatis eius.', active: true },
    { id: 'tab-2', name: 'Neurology', description: 'Voluptas vel esse repudiandae quo excepturi.', active: false },
    { id: 'tab-3', name: 'Hepatology', description: 'Velit veniam ipsa sit nihil blanditiis mollitia natus.', active: false },
    { id: 'tab-4', name: 'Pediatrics', description: 'Ratione hic sapiente nostrum doloremque illum nulla praesentium id', active: false }
  ];
}
