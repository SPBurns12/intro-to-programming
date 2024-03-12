import { Component } from '@angular/core';
import { Store } from '@ngrx/store';

@Component({
  selector: 'app-counter',
  standalone: true,
  imports: [],
  template: `
    <button (click)="increment()" class="btn btn-sm btn-accent">+</button>
    <span>{{ current }}</span>
    <button (click)="decrement()" class="btn btn-sm btn-accent">-</button>
  `,
  styles: ``,
})
export class CounterComponent {
  current = 0;

  constructor(private store: Store) {}

  increment() {
    this.current += 1;
  }
  decrement() {
    this.current -= 1;
  }
}
