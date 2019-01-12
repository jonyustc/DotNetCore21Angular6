import { Hero } from './../hero';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hero-form',
  templateUrl: './hero-form.component.html',
  styleUrls: ['./hero-form.component.css']
})
export class HeroFormComponent implements OnInit {

  powers = ['Really Smart', 'Horse Power', 'Super Flexible'];

  model = new Hero(18, 'Dr IQ', this.powers[1], 'Chunk Overstreet');

  constructor() { }

  ngOnInit() {
  }

  submitted = false;

  onSubmit() {
    this.submitted = true;
  }

  get diagnostic() {
    return JSON.stringify(this.model);
  }


}
