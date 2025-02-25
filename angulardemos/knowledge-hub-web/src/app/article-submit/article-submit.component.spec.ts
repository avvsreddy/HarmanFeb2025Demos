import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArticleSubmitComponent } from './article-submit.component';

describe('ArticleSubmitComponent', () => {
  let component: ArticleSubmitComponent;
  let fixture: ComponentFixture<ArticleSubmitComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ArticleSubmitComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ArticleSubmitComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
