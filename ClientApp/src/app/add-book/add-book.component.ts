import { ActivatedRoute, Router } from '@angular/router';
import { BookService } from './../services/book.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-add-book',
  templateUrl: './add-book.component.html',
  styleUrls: ['./add-book.component.css']
})
export class AddBookComponent implements OnInit {
  authors: any[];

  book = {
    id: 0,
  }
  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private bookservice: BookService
  ) {
    route.params.subscribe(p => {
      this.book.id = +p['id'] || 0;
    }, err => {
      if (err.status == 404) {
        this.router.navigate(['/books']);
      }
    });
  }



  title: any;

  ngOnInit() {
    this.bookservice.getAuthors()
      .subscribe(res => {
        console.log(res);
        this.authors = res;
      });
  }

}
