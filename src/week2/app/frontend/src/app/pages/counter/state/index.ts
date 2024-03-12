import { createFeature, createReducer, on } from '@ngrx/store';
import { CounterAction } from './action';

export interface CounterState {
  current: number;
}

const initialState: CounterState = {
  current: 0,
};

export const counterFeature = createFeature({
  name: 'counter',
  reducer: createReducer(
    initialState,
    on(CounterAction.incrementedTheCount, (state, action) => ({
      current: state.current + 1,
    })),
    on(CounterAction.decrementedTheCount, (state, action) => ({
      current: state.current - 1,
    })),
    on(CounterAction.resetTheCount, (state, action) => ({
      current: 0,
    }))
  ),
});
