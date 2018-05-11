import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { VideosComponent } from './videos/videos.component';
import { VideoCardComponent } from './shared/components/video-card/video-card.component';
import { VideoService } from "./shared/services/video.service";
import { VideoFilterComponent } from './videos/video-filter/video-filter.component';
import { CategoryService } from "./shared/services/category.service";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    VideosComponent,
    VideoCardComponent,
    VideoFilterComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'videos', component: VideosComponent},
    ])
  ],
  providers: [VideoService, CategoryService],
  bootstrap: [AppComponent]
})
export class AppModule { }
