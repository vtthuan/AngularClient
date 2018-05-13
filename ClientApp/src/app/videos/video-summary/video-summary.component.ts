import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { VideoService } from "../../shared/services/video.service";
import { Video } from "../../shared/models/video";

@Component({
  selector: 'video-summary',
  templateUrl: './video-summary.component.html',
  styleUrls: ['./video-summary.component.css']
})
export class VideoSummaryComponent implements OnInit {
  video: Video;

  constructor(private route: ActivatedRoute, private videoService: VideoService) { }

  ngOnInit() {
    const param = this.route.snapshot.paramMap.get('id');
    if (param) {
      const id = +param;
      this.getVideo(id);
    }
  }

  getVideo(id: number) {
    this.videoService.getVideo(id).subscribe(
      video => this.video = video);
  }

  onBack(): void {
  }

}
