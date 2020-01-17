import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';

@Injectable()
export class partRepository {
  constructor(private http: HttpClient) {
  }

  getAllParts() {
    return this.http.get<PartResponse[]>('part/GetAllParts');
  }

  addNewPart(part: PartResponse) {

    //const params = new HttpParams()
    //  .set('id', id.toString())
    //  .set('name', name)
    //  .set('description', description)
    //  .set('weightPounds', weightPounds.toString());

    var result: any = this.http.post<PartResponse>('part/AddNewPart', part);
    return result;
  }
}


export class PartResponse {
  id: number;
  name: string;
  description: string;
  weightPounds: number;
}
