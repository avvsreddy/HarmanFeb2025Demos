import { Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { CategoryCreateComponent } from './category-create/category-create.component';
import { CategoryListComponent } from './category-list/category-list.component';
import { ArticleSubmitComponent } from './article-submit/article-submit.component';
import { ArticleReviewComponent } from './article-review/article-review.component';
import { ArticleBrowseComponent } from './article-browse/article-browse.component';

export const routes: Routes = 
[
    {
        path:'home',
        component:HomeComponent
    },
    {
        path:'category-create',
        component:CategoryCreateComponent
    },
    {
        path:'category-list',
       component:CategoryListComponent
    },
    {
        path:'article-submit',
        component:ArticleSubmitComponent
    },
    {
        path:'article-review',
        component:ArticleReviewComponent
    },
    {
        path:'article-browse',
        component:ArticleBrowseComponent
    }
];
