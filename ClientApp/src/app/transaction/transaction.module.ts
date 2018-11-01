import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { SharedModule } from '../shared/modules/shared.module';
import { RouterModule } from '@angular/router';
import { UserService } from '../shared/services/user.service';

import { PreviewStepComponent } from "./components/preview-step/preview-step.component";
import { routing } from './transaction.routing';

@NgModule({
  imports: [
    CommonModule, routing, FormsModule, SharedModule, RouterModule
  ],
  declarations: [PreviewStepComponent],
  providers: []
})
export class TransactionModule { }
