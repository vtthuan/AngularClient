import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { HomeComponent } from "./home/home.component";
import { VideosComponent } from "./videos/components/videos.component";
import { VideoSummaryComponent } from "./videos/components/video-summary/video-summary.component";
import { AuthGuardService } from "./shared/services/auth-guard.service";
import { PreviewStepComponent } from "./videos/components/video-detail/preview-step/preview-step.component";

export const appRoutes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'preview/:id/:transactionId', canActivate: [AuthGuardService], component: PreviewStepComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(appRoutes, { useHash: true })],
  exports: [RouterModule]
})

export class AppRoutingModule { }
