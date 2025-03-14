import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CountsComponent } from './counts.component';

describe('CountsComponent', () => {
  let component: CountsComponent;
  let fixture: ComponentFixture<CountsComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CountsComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CountsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
