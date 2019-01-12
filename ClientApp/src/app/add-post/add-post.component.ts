import { Component, OnInit } from '@angular/core';
import { PostService } from '../services/post.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-add-post',
  templateUrl: './add-post.component.html',
  styleUrls: ['./add-post.component.css']
})
export class AddPostComponent implements OnInit {

  blogs: any[];

  post = {
    id: 0,
  };

  constructor(
    private route: ActivatedRoute,
    private router: Router,
    private postService: PostService
  ) {

    route.params.subscribe(p => {
      this.post.id = +p['id'] || 0;
    }, err => {
      if (err.status == 404) {
        this.router.navigate(['/post']);
      }
    });

  }



  ngOnInit() {
    this.postService.getBlogs()
      .subscribe(res => this.blogs = res);

    this.postService.getPost(this.post.id)
      .subscribe(b => {
        this.post = b;
      });
  }

  submit() {
    if (this.post.id != 0) {
      this.postService.update(this.post)
        .subscribe(x => {
          console.log(x);
          this.router.navigate(['/post']);
        })
    }
    else {
      this.postService.create(this.post)
        .subscribe(x => {
          console.log(x);
          this.router.navigate(['/post']);
        });
    }
  }

  delete() {
    if (confirm("Are u sure?")) {
      this.postService.delete(this.post.id)
        .subscribe(x => {
          console.log(x);
          this.router.navigate(['/post']);
        });
    }
  }

}
