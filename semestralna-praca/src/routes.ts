import {Routes} from '@angular/router';
import {TableComponent} from './app/sections/table/table.component'

export const appRoutes: Routes = [
    {path:'table', component: TableComponent},
    {path:'', redirectTo: '/table', pathMatch:'full'},
];