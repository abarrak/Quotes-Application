import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { QuotesListDto } from '../models/quotes-list.dto';
import { QuoteDto } from '../models/quote-dto';

@Injectable({
  providedIn: 'root'
})
export class QuotesService {

  constructor(
    private http: HttpClient
  ) { }

  getAll(): Observable<QuotesListDto[]> {
    return this.http.get<QuotesListDto[]>('/quotes/');
  }

  get(id: number): Observable<QuoteDto> {
    return this.http.get<QuoteDto>(`/quotes/${id}`);
  }

  add() {

  }

  update() {

  }

  destroy() {

  }
}
