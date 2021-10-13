import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import {OrderComponent} from './order/order.component';
import {PublicApiComponent} from './public-api/public-api.component';

const routes: Routes = [
  {path: 'order', component: OrderComponent},
  {path: 'publicApi', component: PublicApiComponent},

  { path: '**', component: OrderComponent }
]

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]  
})

export class AppRoutingModule { }

