import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/Rx';

@Injectable()
export class BookService {

  constructor(private http: Http) { }

  getBooks() {
    return this.http.get('/api/books')
      .map(res => res.json());
  }

  getAuthors() {
    return this.http.get('/api/authors')
      .map(res => res.json());
  }

}
