import { Component } from '@angular/core';
import { PrimeComponent } from './prime.component';
import { MatButtonModule } from '@angular/material/button';
import { FormsModule } from '@angular/forms';
import { FormBuilder } from '@angular/forms';

@Component({
  selector: 'app-root',
  //template: '<prime></prime>',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'JVBPrimeAngular';
}
