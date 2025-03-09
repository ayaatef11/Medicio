import { RouterModule, Routes } from '@angular/router';
import { AboutComponent } from './about/about.component';
import { AppointmentComponent } from './appointment/appointment.component';
import { ContactComponent } from './contact/contact.component';
import { CountsComponent } from './counts/counts.component';
import { CtaComponent } from './cta/cta.component';
import { DepartmentComponent } from './department/department.component';
import { DoctorsComponent } from './doctors/doctors.component';
import { FeaturedServicesComponent } from './featured-services/featured-services.component';
import { FeaturesComponent } from './features/features.component';
import { FooterComponent } from './footer/footer.component';
import { FrequentQuestionsComponent } from './frequent-questions/frequent-questions.component';
import { GalleryComponent } from './gallery/gallery.component';
import { HeaderComponent } from './header/header.component';
import { HeroComponent } from './hero/hero.component';
import { PricingComponent } from './pricing/pricing.component';
import { ServicesComponent } from './services/services.component';
import { TestimonialsComponent } from './testimonials/testimonials.component';
import { NgModule } from '@angular/core';

export const routes: Routes = [
{path:'',component:AboutComponent},
// {path:'about',component:AboutComponent},
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

