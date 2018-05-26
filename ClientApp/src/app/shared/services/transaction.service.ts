import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Step } from "../models/step";
import { Transaction } from "../models/transaction";
import { Video } from "../models/video";
import { Router, CanActivate, RouterStateSnapshot, ActivatedRouteSnapshot } from "@angular/router";
@Injectable()
export class TransactionService {
  private baseUrl: string;
  constructor(private http: HttpClient, private router: Router, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  createTransactionIfNotExist(videoId: string ) {
    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let authToken = localStorage.getItem('auth_token');
    headers.append('Authorization', `Bearer ${authToken}`);

    return this.http.post<Transaction>(this.baseUrl + "api/transaction/" + videoId, { headers });
  }

  getTransaction(transactionId: string) {

    let headers = new Headers();
    headers.append('Content-Type', 'application/json');
    let authToken = localStorage.getItem('auth_token');
    headers.append('Authorization', `Bearer ${authToken}`);

    return this.http.get(this.baseUrl + "api/transaction/" + transactionId, { headers })
      .map(response => response.json());
  }

}
