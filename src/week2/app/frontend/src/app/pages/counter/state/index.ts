import { createFeature, createReducer, on } from '@ngrx/store';
import { CounterAction } from './action';

export interface CounterState {
  by: number;
  current: number;
}

const initialState: CounterState = {
  by: 1,
  current: 0,
};

export const counterFeature = createFeature({
  name: 'counter',
  reducer: createReducer(
    initialState,
    on(CounterAction.incrementedTheCount, (state) => ({
      ...state,
      current: state.current + state.by,
    })),
    on(CounterAction.decrementedTheCount, (state) => ({
      ...state,
      current: state.current - state.by,
    })),
    on(CounterAction.resetTheCount, () => initialState),
    on(CounterAction.countByChanged, (state, action) => ({
      ...state,
      by: action.payload,
    }))
  ),
});
