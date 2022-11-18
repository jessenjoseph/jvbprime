import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

@Injectable({
  providedIn: 'root'
})
export class PrimeService {

  private readonly apiUrl: string = '/api/primenumbers';
  primes: number[] =[1, 2, 3];
  constructor(private http: HttpClient) { }

  getPrimesold(numberChoiceInService: number) {
    console.log('choice of number : ' + numberChoiceInService)
    return this.primes;
  }

  getPrimes(numberChoiceInService: number) : Observable<number[]>{
    // this.primes = this.http.get(`${this.apiUrl}/${numberChoiceInService}`);
    return this.primes;
}

  clearResults() {
    this.primes = [];
    return this.primes;
  }
}