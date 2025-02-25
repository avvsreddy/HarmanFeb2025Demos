import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ArticleReviewComponent } from './article-review.component';

describe('ArticleReviewComponent', () => {
  let component: ArticleReviewComponent;
  let fixture: ComponentFixture<ArticleReviewComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ArticleReviewComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ArticleReviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
