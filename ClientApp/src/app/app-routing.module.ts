import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from "./home/home.component";
import { VideosComponent } from "./videos/components/videos.component";
import { VideoSummaryComponent } from "./videos/components/video-summary/video-summary.component";
import { AuthGuardService } from "./shared/services/auth-guard.service";

export const appRoutes: Routes = [
  { path: '', component: VideosComponent, pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes, { useHash: true })],
  exports: [RouterModule]
})

export class AppRoutingModule { }
