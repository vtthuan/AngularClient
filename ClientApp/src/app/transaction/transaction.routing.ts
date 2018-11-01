import { ModuleWithProviders } from '@angular/core';
import { RouterModule } from '@angular/router';

import { AuthGuardService } from "../shared/services/auth-guard.service";
import { PreviewStepComponent } from "./components/preview-step/preview-step.component";

export const routing: ModuleWithProviders = RouterModule.forChild([
   { path: 'PreviewStep/:videoId/:transactionId', component: PreviewStepComponent }
]);



