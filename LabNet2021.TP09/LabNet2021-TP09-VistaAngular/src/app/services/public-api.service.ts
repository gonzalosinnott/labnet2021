import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { PublicApi } from '../models/public-api';

@Injectable({
  providedIn: 'root'
})
export class PublicApiService {
  url = 'http://localhost:65077/Api/PublicApi';

  constructor(private http: HttpClient) { }

  getAllQuotes(): Observable<PublicApi[]> {
    return this.http.get<PublicApi[]>(this.url + '/GetQuote');
  }
}