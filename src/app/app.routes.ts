import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { AboutComponent } from './Components/Core/about/about.component';
import { AppointmentComponent } from './Components/appointment/appointment.component';
import { ContactComponent } from './Components/Core/contact/contact.component';
import { CountsComponent } from './Components/counts/counts.component';
import { DepartmentComponent } from './Components/Core/department/department.component';
import { CtaComponent } from './Components/cta/cta.component';
import { DoctorsComponent } from './Components/Core/doctors/doctors.component';
import { FeaturedServicesComponent } from './Components/featured-services/featured-services.component';
import { FeaturesComponent } from './Components/features/features.component';
import { FooterComponent } from './Components/Core/footer/footer.component';
import { FrequentQuestionsComponent } from './Components/frequent-questions/frequent-questions.component';
import { GalleryComponent } from './Components/gallery/gallery.component';
import { HeaderComponent } from './Components/Core/header/header.component';
import { HeroComponent } from './Components/hero/hero.component';
import { PricingComponent } from './Components/pricing/pricing.component';
import { ServicesComponent } from './Components/Core/services/services.component';
import { TestimonialsComponent } from './Components/testimonials/testimonials.component';

export const routes: Routes = [
{path:'',component:AboutComponent},
 {path:'about',component:AboutComponent},
{path:'appointment',component:AppointmentComponent},
{path:'contact',component:ContactComponent},
{path:'counts',component:CountsComponent},
{path:'cta',component:CtaComponent},
{path:'department',component:DepartmentComponent},
{path:'doctors',component:DoctorsComponent},
{path:'featuredServices',component:FeaturedServicesComponent},
{path:'features',component:FeaturesComponent},
{path:'footer',component:FooterComponent},
{path:'frequent-questions',component:FrequentQuestionsComponent},
{path:'gallery',component:GalleryComponent},
{path:'header',component:HeaderComponent},
{path:'hero',component:HeroComponent},
{path:'pricing',component:PricingComponent},
{path:'services',component:ServicesComponent},
{path:'testimonials',component:TestimonialsComponent}

];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})export class AppRoutingModule { }

