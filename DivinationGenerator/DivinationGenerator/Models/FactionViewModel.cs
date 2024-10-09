using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace DivinationGenerator.Models
{
    public class FactionViewModel
    {
        [Required]
        public string name { get; set; }

        [Required]
        public List<String> divinations {  get; set; }

       
        
    }
}
