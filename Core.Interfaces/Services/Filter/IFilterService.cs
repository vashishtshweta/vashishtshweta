using System.Collections.Generic;

namespace Core.Interfaces.Services.Filter
{
    public interface IFilterService
    {
        public string FilterPrimeNumberfromString(string input);
        
        public string RemovePrimeNumberFromString(string input);
        public bool IsPrime(int number);

        public string SortData(string input);
    }
}
