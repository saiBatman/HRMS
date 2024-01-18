import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NotFoundComponent } from './components/errors/not-found/not-found.component';
import { ValidationMessagesComponent } from './components/errors/validation-messages/validation-messages.component';
import { NavbarComponent } from './navbar/navbar.component';
import { NotFoundsComponent } from './components/errors/not-founds/not-founds.component';



@NgModule({
  declarations: [
    NotFoundComponent,
    ValidationMessagesComponent,
    NavbarComponent,
    NotFoundsComponent
  ],
  imports: [
    CommonModule
  ]
})
export class SharedModule { }
