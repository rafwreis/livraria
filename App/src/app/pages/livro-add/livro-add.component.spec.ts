import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LivroAddComponent } from './livro-add.component';

describe('LivroAddComponent', () => {
  let component: LivroAddComponent;
  let fixture: ComponentFixture<LivroAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LivroAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LivroAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
