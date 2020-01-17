import { Component } from '@angular/core';
import { MatFormFieldModule, MatInputModule } from '@angular/material';
import { partRepository, PartResponse } from '../../../repositories/partRepository';


@Component({
  selector: 'app-addpart',
  templateUrl: './addpart.component.html',
  styleUrls: ['./addpart.component.scss']
})
/** addpart component*/
export class AddpartComponent {
  id: number;
  name: string;
  description: string;
  weight: number;

  /** addpart ctor */
  constructor(private partRepo: partRepository) {

  }

  saveClick() {
    var part = new PartResponse();
    part.id = this.id;
    part.name = this.name;
    part.description = this.description;
    part.weightPounds = this.weight;
    this.partRepo.addNewPart(part);
  }
}
