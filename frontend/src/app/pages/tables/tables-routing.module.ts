import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';
import { TablePageComponent } from './containers';



const routes: Routes = [
  {
    path: '',
    component: TablePageComponent
  }
];

@NgModule({
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [RouterModule]
})

export class TablesRoutingModule {
}
