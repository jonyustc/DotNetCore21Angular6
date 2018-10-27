import { Injectable } from '@angular/core';
import { Http } from '@angular/http';

@Injectable()
export class BookService {

  constructor(private http:Http) { }

  getBooks(){
    return this.http.get('/api/books')
      .map(res=>res.json());
  }

}
