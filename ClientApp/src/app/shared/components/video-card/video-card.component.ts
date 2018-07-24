import { Component, OnInit, Input } from '@angular/core';
import { Video } from "../../models/video";

import {ImagesService} from "../../services/images.service";

@Component({
  selector: 'video-card',
  templateUrl: './video-card.component.html',
  styleUrls: ['./video-card.component.css']
})
export class VideoCardComponent implements OnInit {
  @Input('video') video: Video;

  isImageLoading: boolean;

  constructor(private imagesService: ImagesService) { }

  ngOnInit() {
    // this.getImageFromService();
    // this.video.thumbnailUrl = "https://picsum.photos/200/300/?random";
    //  this.video.thumbnailUrl = "//0001.us.cdn.french.fluentu.com/get-image/?target=content&sizetype=348x194&id=129";
  }

  createImageFromBlob(image: Blob) {
    let reader = new FileReader();
    reader.addEventListener("load", () => {
       this.video.imageToShow = reader.result;
    }, false);
 
    if (image) {
       reader.readAsDataURL(image);
    }
   }
 
   getImageFromService() {
       this.isImageLoading = true;
       this.imagesService.getImage(this.video.thumbnailUrl).subscribe(data => {
         this.createImageFromBlob(data);
         this.isImageLoading = false;
       }, error => {
         this.isImageLoading = false;
         console.log(error);
       });
   }

}
