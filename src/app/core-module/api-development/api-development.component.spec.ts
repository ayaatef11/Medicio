import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ApiDevelopmentComponent } from './api-development.component';

describe('ApiDevelopmentComponent', () => {
  let component: ApiDevelopmentComponent;
  let fixture: ComponentFixture<ApiDevelopmentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ApiDevelopmentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ApiDevelopmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
