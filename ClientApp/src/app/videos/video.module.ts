import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../shared/modules/shared.module';
import { RouterModule } from '@angular/router';
import { UserService } from '../shared/services/user.service';

import { routing } from './video.routing';

import { VideosComponent } from './components/videos.component';
import { VideoFilterComponent } from './components/video-filter/video-filter.component';
import { VideoSummaryComponent } from './components/video-summary/video-summary.component';

@NgModule({
  imports: [
    CommonModule, routing, FormsModule, SharedModule, RouterModule
  ],
  declarations: [VideosComponent, VideoFilterComponent, VideoSummaryComponent],
  providers: [UserService]
})
export class VideoModule { }
