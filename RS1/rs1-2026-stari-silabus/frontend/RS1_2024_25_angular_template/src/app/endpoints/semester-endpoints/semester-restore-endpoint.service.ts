import {MyBaseEndpointAsync} from '../../helper/my-base-endpoint-async.interface';
import {Injectable} from '@angular/core';
import {MyConfig} from '../../my-config';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root',
})
export class SemesterRestoreEndpointService
  implements MyBaseEndpointAsync<number, void> {
  private apiUrl = `${MyConfig.api_address}/students-semesters`;

  constructor(private httpClient: HttpClient) {
  }

  handleAsync(id:number){
    return this.httpClient.post<void>(`${this.apiUrl}/${id}/restore`, null);
  }
}
