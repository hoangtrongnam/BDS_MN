import { Injectable } from '@angular/core';
import { Headers, Http, RequestOptions } from '@angular/http';

import { environment } from '../../environments/environment';
import { map } from 'rxjs/operators';

@Injectable()
export class DangTinService {
  domain = environment.domain;
  abc = this.domain + 'DangTin';

  constructor( private http: Http) { }


    getAll() {
      return this.http.get(this.abc).pipe( map(res => res.json()));
    }
}
