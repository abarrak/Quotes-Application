import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { QuotesRoutingModule } from './quotes-routing.module';
import { ListComponent } from './components/list/list.component';
import { DisplayComponent } from './components/display/display.component';
import { AddComponent } from './components/add/add.component';

@NgModule({
  imports: [
    CommonModule,
    QuotesRoutingModule
  ],
  declarations: [
    ListComponent,
    DisplayComponent,
    AddComponent,
]
})
export class QuotesModule { }
