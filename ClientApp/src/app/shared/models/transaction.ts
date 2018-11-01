import { Step } from "./step";

export interface Transaction {
  id: string;
  steps: Step[];
  currentStep: Step;
  token : string;
}
