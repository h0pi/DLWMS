import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { MyConfig } from '../../my-config';
import { MyBaseEndpointAsync } from '../../helper/my-base-endpoint-async.interface';

export interface SemesterCreateRequest {
  academicYearid?: number; // Nullable for insert
  studyYear: number;
  enrollmentDate: Date;
}

@Injectable({
  providedIn: 'root'
})
export class SemesterCreateEndpointService
  implements MyBaseEndpointAsync<SemesterCreateRequest, number> {
  private apiUrl = `${MyConfig.api_address}/students`;

  constructor(private httpClient: HttpClient) {}
  handleAsync(request: SemesterCreateRequest) {
    return this.httpClient.post<number>(this.apiUrl, request);
  }
  handleAsync1(studentId: number, request: SemesterCreateRequest) {
    return this.httpClient.post<number>(`${this.apiUrl}/${studentId}/semesters`, request);
  }
}
