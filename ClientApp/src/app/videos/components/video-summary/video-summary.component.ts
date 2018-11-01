import { Component, OnInit } from '@angular/core';
import { Location } from '@angular/common';
import { ActivatedRoute, Router } from "@angular/router";
import { VideoService } from "../../../shared/services/video.service";
import { Video } from "../../../shared/models/video";
import { TransactionService } from "../../../shared/services/transaction.service";
@Component({
  selector: 'video-summary',
  templateUrl: './video-summary.component.html',
  styleUrls: ['./video-summary.component.css']
})
export class VideoSummaryComponent implements OnInit {
  video: Video;

  constructor(private route: ActivatedRoute,
    private router : Router,
    private videoService: VideoService,
  private transactionService: TransactionService,
  private location: Location) { }

  ngOnInit() {
    const param = this.route.snapshot.paramMap.get('id');
    if (param) {
      const id = +param;
      this.getVideo(id);
    }
  }

  viewVideo() {
    
  }

  getVideo(id: number) {
    this.videoService.getVideo(id).subscribe(
      video => this.video = video);
  }

  onSubmit(){
    this.transactionService.createTransactionIfNotExist(this.video).subscribe(
      transaction => this.router.navigate([transaction.currentStep.action, this.video.id, transaction.token ]));
  }

  onBack() {
    this.location.back();
  }

}
