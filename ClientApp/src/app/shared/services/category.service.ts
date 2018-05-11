import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Category } from "../models/category";

@Injectable()
export class CategoryService {
  private baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getAll() {
    return this.http.get<Category[]>(this.baseUrl + "api/categories");
  }

}
