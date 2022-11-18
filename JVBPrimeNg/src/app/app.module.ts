import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { PrimeComponent } from './prime.component';
import { NoopAnimationsModule } from '@angular/platform-browser/animations';
import { MatButtonModule } from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import {MatCardModule} from '@angular/material/card';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { PrimeListComponent } from './prime-list/prime-list.component';
import { PrimeService } from './prime.service';


@NgModule({
  declarations: [
    AppComponent, PrimeComponent, PrimeListComponent
  ],
  imports: [
    BrowserModule,
    MatButtonModule,
    MatInputModule,
    MatCardModule,
    FormsModule,
    HttpClientModule,
    NoopAnimationsModule
  ],
  providers: [PrimeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
