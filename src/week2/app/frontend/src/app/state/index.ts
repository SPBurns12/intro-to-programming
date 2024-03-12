// tell typescript about application state - what it looks like

import { ActionReducerMap } from '@ngrx/store';

export interface ApplicationState {}
// then I'm going to tell ngrx store that this is what the state is

export const reducers: ActionReducerMap<ApplicationState> = {};
