import { Component } from '@angular/core';
import { PricingPlan } from '../Models/PricingPlan.model';
import { NgFor, NgIf } from '@angular/common';

@Component({
  selector: 'app-pricing',
  standalone: true,
  imports: [NgFor,NgIf],
  templateUrl: './pricing.component.html',
  styleUrl: './pricing.component.css'
})
export class PricingComponent {
  pricingPlans: PricingPlan[] = [
    new PricingPlan("Free", 0, [
      { text: "Aida dere", available: true },
      { text: "Nec feugiat nisl", available: true },
      { text: "Nulla at volutpat dola", available: true },
      { text: "Pharetra massa", available: false },
      { text: "Massa ultricies mi", available: false }
    ]),
    new PricingPlan("Business", 19, [
      { text: "Aida dere", available: true },
      { text: "Nec feugiat nisl", available: true },
      { text: "Nulla at volutpat dola", available: true },
      { text: "Pharetra massa", available: true },
      { text: "Massa ultricies mi", available: false }
    ], true), // Featured plan
    new PricingPlan("Developer", 29, [
      { text: "Aida dere", available: true },
      { text: "Nec feugiat nisl", available: true },
      { text: "Nulla at volutpat dola", available: true },
      { text: "Pharetra massa", available: true },
      { text: "Massa ultricies mi", available: true }
    ]),
    new PricingPlan("Ultimate", 49, [
      { text: "Aida dere", available: true },
      { text: "Nec feugiat nisl", available: true },
      { text: "Nulla at volutpat dola", available: true },
      { text: "Pharetra massa", available: true },
      { text: "Massa ultricies mi", available: true }
    ], false, true) // Advanced plan
  ];
}
