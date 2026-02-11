// DTO za zahtjev
import {MyBaseEndpointAsync} from '../../helper/my-base-endpoint-async.interface';
import {MyPagedList} from '../../helper/my-paged-list';
import {Injectable} from '@angular/core';
import {MyConfig} from '../../my-config';
import {HttpClient} from '@angular/common/http';
import {buildHttpParams} from '../../helper/http-params.helper';
import {MyPagedRequest} from '../../helper/my-paged-request';
import {Observable} from 'rxjs';

export interface SemesterGetAllRequest extends MyPagedRequest {
  q?: string; // Upit za pretragu (ime, prezime, broj indeksa, itd.)
  status?: string;
}

// DTO za odgovor
export interface SemesterGetAllResponse {
  id: number;
  studyYear: Date;
  academicYearDesc: string;
  enrollmentDate: string;
  tuitionFee: number;
  isRenewal?: boolean;
  isDeleted?: boolean;
}

@Injectable({
  providedIn: 'root',
})
export class SemesterGetAllEndpointService
  implements MyBaseEndpointAsync<SemesterGetAllRequest, MyPagedList<SemesterGetAllResponse>> {
  private apiUrl = `${MyConfig.api_address}/students`;

  constructor(private httpClient: HttpClient) {
  }

  handleAsync(request: SemesterGetAllRequest): Observable<MyPagedList<SemesterGetAllResponse>>{
    throw new Error("Method not implemented.");
  }
  handleAsync1(studentId: number, request: SemesterGetAllRequest) {
    const params = buildHttpParams(request); // Pretvori DTO u query parametre
    return this.httpClient.get<MyPagedList<SemesterGetAllResponse>>(`${this.apiUrl}/${studentId}/semesters/filter`, {params});
  }
}
