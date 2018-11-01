import { Component, OnInit, Input } from '@angular/core';
import { Video } from "../../models/video";
import { DomSanitizer} from '@angular/platform-browser';

@Component({
  selector: 'video-card',
  templateUrl: './video-card.component.html',
  styleUrls: ['./video-card.component.css']
})
export class VideoCardComponent {
  @Input('video') video: Video;

  isImageLoading: boolean;

  constructor(private _domSanitizer: DomSanitizer) { }

}
