import { Component, HostBinding, Input, HostListener, Output, EventEmitter } from '@angular/core';
import { SafeStyle, DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-workdayhourstile',
  templateUrl: './workdayhourstile.component.html',
  styleUrls: ['./workdayhourstile.component.scss']
})
/** workdayhourstile component*/
export class WorkdayhourstileComponent {
  @Input() selected: boolean = false;
  color: string = 'darkblue';
  @Input() timeSlot: string = "";
  @Output() onTileClicked: EventEmitter<any> = new EventEmitter();


  /** workdayhourstile ctor */
  constructor(private doms: DomSanitizer) {
    
  }

  @HostBinding('style') get myStyle(): SafeStyle {
    let style: string = this.selected ? `background: ${this.color}` : '';
    return this.doms.bypassSecurityTrustStyle(style);
  }

  @HostListener('click') onClick() {
    this.selected = !this.selected;
    this.onTileClicked.emit({ timeSlot: this.timeSlot, selected: this.selected });
  }

}
