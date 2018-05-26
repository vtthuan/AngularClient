import { Component, OnInit } from '@angular/core';
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
  private transactionService: TransactionService) { }

  ngOnInit() {
    const param = this.route.snapshot.paramMap.get('id');
    if (param) {
      const id = +param;
      this.getVideo(id);
    }
  }

  viewVideo() {
    this.transactionService.createTransactionIfNotExist(this.video.id).subscribe(
      transaction => this.router.navigate([transaction.currentStep.name, this.video.id, transaction.id ]));
  }

  getVideo(id: number) {
    this.videoService.getVideo(id).subscribe(
      video => this.video = video);
  }

  onBack(): void {
  }

}
