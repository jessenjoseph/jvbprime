import { Component, Input, Output, EventEmitter, OnInit } from '@angular/core';

import { PrimeService } from './prime.service';

@Component({
  selector: 'prime',
  templateUrl: './prime.component.html',
})
export class PrimeComponent implements OnInit{
  inputn: number = 28;
  defaultInputn: number = 27;
  results: number[] = [];
  // results: number[] = this.primeService.getPrimes(30);

  constructor(private primeService: PrimeService) { }

  ngOnInit(): void {
    if(this.inputn === undefined)
    {
      this.inputn = this.defaultInputn;
    }

    this.results = this.getPrimeNumbersFromService(this.inputn);

    console.log(this.results);
  }

  getPrimeNumbersFromService(numberInput: number): number[] {
    return this.primeService.getPrimes(numberInput);
  }

  getPrimeNumbers(numberInput: any) {
    if(numberInput == null)
    {
      numberInput = this.defaultInputn;
    }
    console.log("you are in prime.component.ts");
    console.log(numberInput);
  }

  onSubmit() {
    console.log('OnSubmit in pct . You will be ..');
    this.results = this.getPrimeNumbersFromService(75);
    console.log(this.results);
  }
}
