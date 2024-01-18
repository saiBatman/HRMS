import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { NotFoundsComponent } from './Shared/components/errors/not-founds/not-founds.component';

const routes: Routes = [
  {path:'',component:HomeComponent},
  {path:'account', loadChildren:()=>import('./account/account.module').then(module=>module.AccountModule)},
  {path:'not-found',component:NotFoundsComponent},
  {path:'**', component:NotFoundsComponent, pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
