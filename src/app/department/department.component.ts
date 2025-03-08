import { NgFor } from '@angular/common';
import { Component } from '@angular/core';
import { Department } from '../Models/Department.model';

@Component({
  selector: 'app-department',
  standalone: true,
  imports: [NgFor],
  templateUrl: './department.component.html',
  styleUrl: './department.component.css'
})
export class DepartmentComponent {
 public  departments:Department[] = [
   new Department (  'tab-1',  'Cardiology', 'Quis excepturi porro totam sint earum quo nulla perspiciatis eius.', true ),
   new Department (  'tab-2',  'Neurology', 'Voluptas vel esse repudiandae quo excepturi.', false ),
   new Department(  'tab-3',  'Hepatology', 'Velit veniam ipsa sit nihil blanditiis mollitia natus.', false ),
   new Department(  'tab-4',  'Pediatrics', 'Ratione hic sapiente nostrum doloremque illum nulla praesentium id', false )
  ];
}
