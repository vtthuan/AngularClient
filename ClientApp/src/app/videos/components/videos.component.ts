import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import 'rxjs/add/operator/switchMap';
import { Video } from "../../shared/models/video";
import { VideoService } from "../../shared/services/video.service";

@Component({
  selector: 'app-videos',
  templateUrl: './videos.component.html',
  styleUrls: ['./videos.component.css']
})
export class VideosComponent implements OnInit {

  category: number;
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
      .subscribe(params => { this.category = +params.get("category"); this.applyFilter(); });
  }

  private applyFilter() {
    this.videosFiltered = (this.category) ?
      this.videos.filter(v => v.categoryId === this.category) :
      this.videos;

      // this.videosFiltered.forEach((key)=> key.thumbnailUrl = "local")
  }

}
