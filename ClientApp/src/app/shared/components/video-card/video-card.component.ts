import { Component, OnInit, Input } from '@angular/core';
import { Video } from "../../models/video";

@Component({
  selector: 'video-card',
  templateUrl: './video-card.component.html',
  styleUrls: ['./video-card.component.css']
})
export class VideoCardComponent implements OnInit {
  @Input('video') video: Video;
  constructor() { }

  ngOnInit() {
  }

}
