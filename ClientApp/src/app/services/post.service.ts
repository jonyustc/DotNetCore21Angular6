import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/Rx';

@Injectable()
export class PostService {

  constructor(private http: Http) { }

  getPosts() {
    return this.http.get('/api/post')
      .map(res => res.json());
  }

  getPost(id: any) {
    return this.http.get('/api/post/' + id)
      .map(res => res.json());
  }

  create(post: any) {
    return this.http.post('/api/post', post)
      .map(res => res.json());
  }

  update(post: any) {
    return this.http.put('/api/post/' + post.id, post)
      .map(res => res.json());
  }

  delete(id: any) {
    return this.http.delete('/api/post/' + id)
      .map(res => res.json());
  }

  getBlogs() {
    return this.http.get('/api/blog')
      .map(res => res.json());
  }

}
