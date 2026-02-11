import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MyConfig } from '../../my-config';
import { MyBaseEndpointAsync } from '../../helper/my-base-endpoint-async.interface';
import {Observable} from 'rxjs';



export interface SemesterUpdateOrInsertRequest {
  academicYearId: number;
  studyYear: number;
  enrollmentDate: Date;
}

@Injectable({
  providedIn: 'root'
})
export class SemesterUpdateOrInsertEndpointService
  implements MyBaseEndpointAsync<SemesterUpdateOrInsertRequest, number> {
  private apiUrl = `${MyConfig.api_address}/students`;

  constructor(private httpClient: HttpClient) {}

  handleAsync(request: SemesterUpdateOrInsertRequest): Observable<number> {
    throw new Error("Method not implemented.");
  }

  handleAsync1(studentId:number,request: SemesterUpdateOrInsertRequest) {
    return this.httpClient.post<number>(`${this.apiUrl}/${studentId}/semesters`, request);
  }
}
