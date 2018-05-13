import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { HttpModule } from '@angular/http';
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

/* Routing Module */
import { AppRoutingModule } from './app-routing.module';
/* Account Imports */
import { AccountModule } from './account/account.module';
import { VideoSummaryComponent } from './videos/video-summary/video-summary.component';
import { VideoDetailComponent } from './videos/video-detail/video-detail.component';
import { AuthGuardService } from "./shared/auth-guard.service";

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    VideosComponent,
    VideoCardComponent,
    VideoFilterComponent,
    VideoSummaryComponent,
    VideoDetailComponent
  ],
  imports: [
    AppRoutingModule,
    AccountModule,
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [VideoService, CategoryService, AuthGuardService ],
  bootstrap: [AppComponent]
})
export class AppModule { }
