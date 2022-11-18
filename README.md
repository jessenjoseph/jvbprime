# jvbprime
Problem Statement
Create a web API in C# that accepts an integer between 1 and 100. The API should return all
prime numbers less than the input value.
Create an Angular front end that will consume this Web API.


PrimeNumbers API
The PrimeNumbers API allows you to obtain all prime numbers less than the input value. 


GET api/primenumbers/{inputValue}

Angular

I had come across a lot of errors when doing the Angular implementation. Trouble fixing the binding.

Eventually I would realise the error. In normal circumstances, I would request a 2nd pair of eyes soon after I realised that I have spent more time than usual. Google wasnt helpful at all. It felt so doable. Sorry for the delay in getting thisto you. Didnt expect to come across errors
src/app/prime.service.ts:3:28 - error TS2307: Cannot find module 'rxjs/Observable' or its corresponding type declarations
