import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from "./home/home.component";
import { VideoDetailComponent } from "./videos/video-detail/video-detail.component";
import { VideosComponent } from "./videos/videos.component";
import { VideoSummaryComponent } from "./videos/video-summary/video-summary.component";
import { AuthGuardService } from "./shared/auth-guard.service";

export const appRoutes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'videos', component: VideosComponent },
  { path: 'videos/:id', component: VideoSummaryComponent },
  { path: 'detail/:id', canActivate: [AuthGuardService], component: VideoDetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes, { useHash: true })],
  exports: [RouterModule]
})

export class AppRoutingModule { }
