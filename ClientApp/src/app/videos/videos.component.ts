import { Component, OnInit } from '@angular/core';
import { Video } from "../shared/models/video";
import { VideoService } from "../shared/services/video.service";
import { ActivatedRoute } from "@angular/router";
import 'rxjs/add/operator/switchMap';

@Component({
  selector: 'app-videos',
  templateUrl: './videos.component.html',
  styleUrls: ['./videos.component.css']
})
export class VideosComponent implements OnInit {

  category: string;
  videosFiltered: Video[] = [];
  videos: Video[] = [];
  constructor(private videoService: VideoService,
    private routeService: ActivatedRoute
  ) { }

  async ngOnInit() {
    this.populateVideos();
  }

  private populateVideos() {
    this.videoService.getAll()      
      .switchMap(videos => {
        this.videos = videos;
        return this.routeService.queryParamMap;
      })
      .subscribe(params => { this.category = params.get("category"); this.applyFilter(); });
  }

  private applyFilter() {
    this.videosFiltered = (this.category) ?
      this.videos.filter(v => v.category === this.category) :
      this.videos;
  }

}
