import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-workdayhours',
  templateUrl: './workdayhours.component.html',
  styleUrls: ['./workdayhours.component.scss']
})
/** workdayhours component*/
export class WorkdayhoursComponent {
  @Input() dayOfWeek: string = "";

  /** workdayhours ctor */
  constructor() {

  }

  tileClicked($event) {
    console.log($event);
  }
}
