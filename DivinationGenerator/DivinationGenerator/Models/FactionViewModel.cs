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

        public FactionViewModel(string givenName) 
        { 
            name = givenName;
            switch (name)
            {
                case "Rogue Trader Dynasty":
                    divinations = new List<String>()
                    {
                        "It is better to die for the Emperor than to live for yourself",
                        "Trust in your zeal - it is a weapon with no equal",
                        "A small mind is a tidy mind",
                        "To embrace the xenos is to welcome your own damnation",
                        "Duty prevails",
                        "The wise learn from the deaths of others",
                        "Destroy the xenos before it can speak its lies",
                        "Logic is the enemy of faith",
                        "Thought begets heresy",
                        "Heresy begets retribution",
                        "A mind without purpose will wander in dark places",
                        "By the manner of our death are we judged",
                        "Success is measured in blood: yours or your enemy's",
                        "The Emperor bestows upon us the gift of intolerance",
                        "True faith is blind and justified",
                        "There is no substitute for zeal",
                        "Even one who has nothing can still offer their life",
                        "The blood of martyrs is the seed of the Imperium",
                        "Call no one happy until they are dead",
                        "An open mind is like a fortress with its gates unbarred and unguarded",
                        "In the blood of martyrs is the blade of the Imperium made strong",
                        "A moment of heresy blights a lifetime of duty",
                        "Ruthlessness is the kindness of the wise",
                        "A coward seeks compromise",
                        "Only in death does duty end"
                    };
                    break;

                case "Infractionist":
                    divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                case "Imperial Fleet":
                    divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                case "The Inquisition":
                    divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                case "Adeptus Ministorum":
                    divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                default:
                    divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;
            }
        }
    }
}
