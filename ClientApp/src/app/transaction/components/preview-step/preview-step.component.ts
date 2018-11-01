import { Component, OnInit } from '@angular/core';
import { Video } from "../../../shared/models/video";
import { Transaction } from "../../../shared/models/transaction";
import { TransactionService } from "../../../shared/services/transaction.service";

@Component({
  selector: 'preview-step',
  templateUrl: './preview-step.component.html',
  styleUrls: ['./preview-step.component.css']
})
export class PreviewStepComponent implements OnInit {
  private video: Video;
  private transaction: Transaction;
  constructor(private transactionService: TransactionService) { }

  ngOnInit() {
    // this.transactionService.getTransaction(this.video)
    //   .subscribe(transaction => this.transaction = transaction);
  }
}
