import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpClientModule , HttpHeaders } from "@angular/common/http";
import { Router, CanActivate, RouterStateSnapshot, ActivatedRouteSnapshot } from "@angular/router";

import { Observable } from 'rxjs/Rx';

@Injectable()
export class ImagesService {

  private baseUrl: string;
  constructor(private http: HttpClient, private router: Router, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getImage(url : string) : Observable<Blob> {
    return this.http.get(url, { responseType: 'blob' });
  }

}
