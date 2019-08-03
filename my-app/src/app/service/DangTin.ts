import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions } from '@angular/http';

import { environment } from '../../environments/environment';
import { map } from 'rxjs/operators';

import { DangTinModel } from '../models/dangtin';
import { DangTin_Request } from '../models/dangtin_Request';
import { Observable } from 'rxjs';

@Injectable()
export class DangTinService {
  domain = environment.domain;
  abc = this.domain + 'DangTin';

  constructor( private http: Http) { }


    getAll() {
      return this.http.get(this.abc).pipe( map(res => res.json()));
    }
    // public getAccountingEntryInfo(data: DangTin_Request): Observable<DangTinModel> {
    //   return this.get<DangTinModel>(this.abc,data);
    // }
}
