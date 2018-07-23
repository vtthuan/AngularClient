import { Component, OnInit, Input } from '@angular/core';
import { Step } from "../../../shared/models/step";


@Component({
  selector: 'nav-steps',
  templateUrl: './nav-steps.component.html',
  styleUrls: ['./nav-steps.component.css']
})
export class NavStepsComponent implements OnInit {
  @Input('steps') steps: Step[];
  constructor() { }

  ngOnInit() {
  }

}
