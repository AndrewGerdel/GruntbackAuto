import { Component } from '@angular/core';
import { partRepository } from '../../../repositories/partRepository';

@Component({
  selector: 'app-parts',
  templateUrl: './parts.component.html',
  styleUrls: ['./parts.component.scss']
})
/** parts component*/
export class PartsComponent {
  allParts: any;

  /** parts ctor */
  constructor(partRepo: partRepository) {
    partRepo.getAllParts().subscribe((data) => {
      this.allParts = JSON.stringify(data);
    }, (error) => {
        console.log("error: " + error);
    });
  }
}
