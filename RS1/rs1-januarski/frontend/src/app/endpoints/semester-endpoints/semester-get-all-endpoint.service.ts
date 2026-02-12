import {Injectable} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {MyPagedRequest} from '../../helper/my-paged-request';
import {MyConfig} from '../../my-config';
import {buildHttpParams} from '../../helper/http-params.helper';
import {MyBaseEndpointAsync} from '../../helper/my-base-endpoint-async.interface';
import {MyPagedList} from '../../helper/my-paged-list';
import {Observable} from 'rxjs';

// DTO za zahtjev
export interface SemesterGetAllRequest extends MyPagedRequest {
  q?: string; // Upit za pretragu (ime, prezime, broj indeksa, itd.)
  status?: string; // Upit za pretragu (ime, prezime, broj indeksa, itd.)
}

// DTO za odgovor
export interface SemesterGetAllResponse {

  id: number;
  academicYearDesc: string;
  studyYear: number;
  enrollmentDate: string;
  isRenewal: boolean; // Državljanstvo
  tuitionFee: number;
  isDeleted: boolean;// Općina rođenja
}

@Injectable({
  providedIn: 'root',
})
export class SemesterGetAllEndpointService
  implements MyBaseEndpointAsync<SemesterGetAllRequest, MyPagedList<SemesterGetAllResponse>> {
  private apiUrl = `${MyConfig.api_address}/students`;

  constructor(private httpClient: HttpClient) {
  }

  handleAsync(request: SemesterGetAllRequest):Observable<MyPagedList<SemesterGetAllResponse>> {
    throw Error("this method is not implemented.");
  }
  handleAsync1(studentId: number, request: SemesterGetAllRequest){
    const params = buildHttpParams(request); // Pretvori DTO u query parametre
    return this.httpClient.get<MyPagedList<SemesterGetAllResponse>>(`${this.apiUrl}/${studentId}/semesters/filter`, {params});
  }
}
