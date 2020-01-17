import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpClientModule } from '@angular/common/http';

@Injectable()
export class partRepository {
  constructor(private http: HttpClient) {
  }

  getAllParts() {
    return this.http.get<PartResponse[]>('part/GetAllParts');
  }
}


export class PartResponse {
  id: number;
  name: string;
  description: string;
  weightPounds: number;
}
