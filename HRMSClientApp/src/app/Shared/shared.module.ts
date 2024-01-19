import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NotFoundsComponent } from './components/errors/not-founds/not-founds.component';
import { RouterModule } from '@angular/router';
import { ValidationMessagesComponent } from './Components/errors/validation-messages/validation-messages.component';



@NgModule({
  declarations: [
    ValidationMessagesComponent,
    NotFoundsComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports:[
    RouterModule
  ]
})
export class SharedModule { }
