import { Component } from '@angular/core';
import { Store } from '@ngrx/store';
import { counterFeature } from './state';
import { CounterAction } from './state/action';

@Component({
  selector: 'app-counter',
  standalone: true,
  imports: [],
  template: `
    <button (click)="increment()" class="btn btn-sm btn-accent">+</button>
    <span>{{ current() }}</span>
    <button (click)="decrement()" class="btn btn-sm btn-accent">-</button>
    <div>
      <button
        [disabled]="current() === 0"
        (click)="reset()"
        class="btn btn-sm btn-accent"
      >
        Reset
      </button>
    </div>
  `,
  styles: ``,
})
export class CounterComponent {
  constructor(private store: Store) {}
  current = this.store.selectSignal(counterFeature.selectCurrent);

  increment() {
    this.store.dispatch(CounterAction.incrementedTheCount());
  }
  decrement() {
    this.store.dispatch(CounterAction.decrementedTheCount());
  }
  reset() {
    this.store.dispatch(CounterAction.resetTheCount());
  }
}
