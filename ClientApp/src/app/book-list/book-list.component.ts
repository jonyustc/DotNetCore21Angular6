import { BookService } from './../services/book.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  constructor(private bookService:BookService) { }

  books:any[];


  ngOnInit() {
    this.bookService.getBooks()
      .subscribe(res=>{
        console.log(res);
        this.books=res;
      });
  }

}
