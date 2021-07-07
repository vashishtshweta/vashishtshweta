using Core.Interfaces.Services.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CoreServices.Filter
{
    public class FilterService : IFilterService
    {
        //Remove prime number form the input string.
        public string RemovePrimeNumberFromString(string input)
        {
            List<int> numbers = Regex.Split(input, @"\D+").Where(s => s != String.Empty).Select(s => Convert.ToInt32(s)).ToList();
            var filteredText = Regex.Split(input, @"\s+").ToList();
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    filteredText.Remove(number.ToString());
                }

            }

            var result = String.Join(" ", filteredText);
            return result.ToString();
        }


        //To check whether a number is a prime number or not 
        public bool IsPrime(int number)
        {
            if (number <= 3 && number > 1)
                return true;            // as 2 and 3 are prime
            else if ( number % 2 == 0 || number % 3 == 0 )
                return false;     // check if number is divisible by 2 or 3
            else
            {
                for (int i = 5; i * i <= number; i += 6)
                {
                    if (number % i == 0 || number % (i + 2) == 0)
                        return false;
                }
                return true;
            }
        }
        

        //Additional function to get the Prime numbers in a string
        public string FilterPrimeNumberfromString (string input)
        {
            List<int> numbers = Regex.Split(input, @"\D+").Where(s => s != String.Empty).Select(s => Convert.ToInt32(s)).ToList();
            List<int> primeNumberList = new List<int>();
            foreach (int number in numbers)
            {
                if (IsPrime(number))
                {
                    primeNumberList.Add(number);
                }

            }
            var result = String.Join(" ", primeNumberList);
            return result.ToString();
        }

        //OrderBy method to sort the Input string text
        public string SortData(string input)
        {
            List<int> numbers = Regex.Split(input, @"\D+").Where(s => s != String.Empty).Select(s => Convert.ToInt32(s)).OrderBy(x => x).ToList();
            var stringData = Regex.Matches(input, @"[a-z]+|[A-Z]+ \s").Select(s => s.Value).OrderBy(s => s.ToString()).ToList();
            var result = numbers.Select(s => s.ToString()).Concat(stringData).ToList();
             var sortedOutput = String.Join(" ", result);
            return sortedOutput.ToString();
        }
    }
}
