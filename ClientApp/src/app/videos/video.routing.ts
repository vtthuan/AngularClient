import { ModuleWithProviders } from '@angular/core';
import { RouterModule } from '@angular/router';

import { VideosComponent } from "../videos/components/videos.component";
import { VideoSummaryComponent } from "../videos/components/video-summary/video-summary.component";
import { AuthGuardService } from "../shared/services/auth-guard.service";

export const routing: ModuleWithProviders = RouterModule.forChild([
  { path: 'videos', component: VideosComponent },
  { path: 'videos/:id', component: VideoSummaryComponent }
]);



