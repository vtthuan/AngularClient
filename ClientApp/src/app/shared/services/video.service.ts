import { Injectable, Inject } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Video } from "../models/video";

@Injectable()
export class VideoService {
  private baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
  }

  getAll() {
     return this.http.get<Video[]>(this.baseUrl + "api/videos");
  }

}
