import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
 
import { SpinnerComponent} from '../../spinner/spinner.component';  
import { VideoCardComponent } from '../components/video-card/video-card.component';
import { AuthGuardService } from "../services/auth-guard.service";
import { VideoService } from "../services/video.service";
import { TransactionService } from "../services/transaction.service";
import { CategoryService } from "../services/category.service";

@NgModule({
  imports: [CommonModule],
  declarations: [SpinnerComponent, VideoCardComponent],
  exports: [SpinnerComponent, VideoCardComponent
    ],
  providers: [AuthGuardService, VideoService, TransactionService, CategoryService]
})
export class SharedModule { }
