
namespace JVBWebApp.Helpers
{
    public interface IPrimeNumbersGetter
    {
        IEnumerable<int> GetPrimeNumbersBeforeGivenNumber(int inputNumber);
    }
}