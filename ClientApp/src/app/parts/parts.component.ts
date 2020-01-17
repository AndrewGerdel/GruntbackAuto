import { Component } from '@angular/core';
import { partRepository, PartResponse } from '../../../repositories/partRepository';

@Component({
  selector: 'app-parts',
  templateUrl: './parts.component.html',
  styleUrls: ['./parts.component.scss']
})
/** parts component*/
export class PartsComponent {
  allParts: PartResponse[] = [];

  /** parts ctor */
  constructor(partRepo: partRepository) {
    partRepo.getAllParts().subscribe((data) => {
      this.allParts = data;
    }, (error) => {
        console.log("error: " + error);
    });
  }

  addNewPart() {
    
    location.href = "/addpart";
  }

}
