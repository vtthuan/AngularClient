import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpClientModule , HttpHeaders } from "@angular/common/http";
import { Step } from "../models/step";
import { Transaction } from "../models/transaction";
import { Video } from "../models/video";
import { Router, CanActivate, RouterStateSnapshot, ActivatedRouteSnapshot } from "@angular/router";


import { Observable } from 'rxjs/Rx';

// Add the RxJS Observable operators we need in this app.
@Injectable()
export class TransactionService {
  private baseUrl: string;
  constructor(private http: HttpClient, private router: Router, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  createTransactionIfNotExist(video: Video ) : Observable<Transaction> {
     let headers = new HttpHeaders();
    // headers.append('Content-Type', 'application/json');
    // let authToken = localStorage.getItem('auth_token');
    // headers.append('Authorization', `Bearer ${authToken}`);

    return this.http.post<Transaction>(this.baseUrl + "api/transaction/", video, { headers });
  }

  getTransaction(transactionId: string) : Observable<Transaction> {

    let headers = new HttpHeaders();
    headers.append('Content-Type', 'application/json');
    let authToken = localStorage.getItem('auth_token');
    headers.append('Authorization', `Bearer ${authToken}`);

    return this.http.get<Transaction>(this.baseUrl + "api/transaction/" + transactionId, { headers });
  }

}
