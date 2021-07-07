using System.ComponentModel.DataAnnotations;

namespace Fignum.WebApplication.Features.Home
{
    public class IndexViewModel
    {
        [Display(Name = "Enter a string ")]
         public string PassedInValue { get; set; }

        public string PrimeNumber { get; set; }

        public string OriginalInput { get; set; }
    }
}
