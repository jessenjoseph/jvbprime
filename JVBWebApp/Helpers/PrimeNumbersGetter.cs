namespace JVBWebApp.Helpers
{
    public class PrimeNumbersGetter : IPrimeNumbersGetter
    {
        /*Create a web API in C# that accepts an integer between 1 and 100. The API should return all
         prime numbers less than the input value.*/

        public IEnumerable<int> GetPrimeNumbersBeforeGivenNumber(int inputNumber)
        {
            var primeNumbers = new List<int>();

            if(inputNumber <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(inputNumber));
            }

            for (var i = 1; i < inputNumber; i++)
            {
                if (IsPrimeNumber(i))
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }

        private static bool IsPrimeNumber(int numberToCheck)
        {
            var result = true;
            for (int i = 2; i <= numberToCheck / 2; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }

            return result;
        }
    }
}
