import { Component, Input, OnInit, Output, EventEmitter  } from '@angular/core';

@Component({
  selector: 'app-prime-list',
  templateUrl: './prime-list.component.html',
})
export class PrimeListComponent {
  @Input() inputn!: number;  
  @Output() submit = new EventEmitter();
}
