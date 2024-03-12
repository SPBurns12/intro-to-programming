import { createActionGroup, emptyProps } from '@ngrx/store';
export const CounterAction = createActionGroup({
  source: 'Counter Component Events',
  events: {
    'Incremented the count': emptyProps(),
    'Decremented the count': emptyProps(),
    'Reset the count': emptyProps(),
  },
});
