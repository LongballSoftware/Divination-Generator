using DivinationGenerator.Models;
using System.Xml.Linq;

namespace DivinationGenerator.Orchestrators
{
    public class CharacterOrchestrator
    {




        public CharacterOrchestrator() { }


        public CharacterViewModel UpdateFaction(CharacterViewModel character, string factionName)
        {
            character.faction = new FactionViewModel();
            character.faction.name = factionName;
            switch (character.faction.name)
            {
                case "Rogue Trader Dynasty":
                    character.faction.divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                case "Adeptus Astra Telepathica":
                    character.faction.divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                case "Adeptus Administratum":
                    character.faction.divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                case "Infractionist":
                    character.faction.divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                case "Imperial Fleet":
                    character.faction.divinations = new List<String>()
                    {
                        "not implemented"
                    };
                    break;

                case "The Inquisition":
                    character.faction.divinations = new List<String>()
                    {
                       "Innocence Proves Nothing"
                    };
                    break;

                case "Adeptus Ministorum":
                    character.faction.divinations = new List<String>()
                    {
                        "It is better to die for the Emperor than to live for yourself",
                        "Trust in your zeal - it is a weapon with no equal",
                        "A small mind is a tidy mind",
                        "To embrace the xenos is to welcome your own damnation",
                        "Duty prevails",
                        "The wise learn from the deaths of others",
                        "Logic is the enemy of faith",
                        "Thought begets heresy",
                        "Heresy begets retribution",
                        "By the manner of our death are we judged",
                        "The Emperor bestows upon us the gift of intolerance",
                        "True faith is blind and justified",
                        "The blood of martyrs is the seed of the Imperium",
                        "An open mind is like a fortress with its gates unbarred and unguarded",
                        "In the blood of martyrs is the blade of the Imperium made strong",
                        "A moment of heresy blights a lifetime of duty",
                        "Ruthlessness is the kindness of the wise",
                        "Death is the servant of the righteous",
                        "Blessed is the mind too small for doubt",
                        "Burn the Unclean with the fires of Purity",
                        "Turn from the Emperor's light at your peril",
                        "There is nothing to fear but failure",
                        "Doubt is a sign of weakness",
                        "The greatest armor is contempt",
                        "Hatred is the Emperor's greatest gift to Humanity",
                        "Doubt forms the path to damnation",
                        "Suffering is an unrelenting instructor",
                        "Hope is the first step on the road to disappointment",
                        "Carry the Emperor's Will as your torch; with it destroy the shadows",
                        "Heresy grows from idleness",
                        "Burn the Heretic! Kill the Mutant! Purge the Unclean!",
                        "Beware the young, the child, even the babe",
                    };
                    break;

                case "Adeptus Mechanicus":
                    character.faction.divinations = new List<string>()
                    {
                        "Trust in your zeal - it is a weapon with no equal",
                        "A small mind is a tidy mind",
                        "To embrace the xenos is to welcome your own damnation",
                        "The wise learn from the deaths of others",
                        "Destroy the xenos before it can speak its lies",
                        "Heresy begets retribution",
                        "A mind without purpose will wander in dark places",
                        "By the manner of our death are we judged",
                        "Even one who has nothing can still offer their life",
                        "Call no one happy until they are dead",
                        "A moment of heresy blights a lifetime of duty",
                        "Ruthlessness is the kindness of the wise",
                        "Even in death, we serve the Omnissiah",
                        "Death is the servant of the righteous",
                        "Success is commemorated; failure is merely remembered",
                        "Mercy is a sign of weakness",
                        "Innocence proves nothing",
                        "A coward always seeks compromise",
                        "Turn from the wisdom of the Omnissiah at your peril",
                        "There is nothing to fear but failure",
                        "Suffering is an unrelenting instructor",
                        "Hope is the first step on the road to disappointment",
                        "Forgiveness is a sign of weakness",
                        "Do not ask why you serve, only ask how",
                        "All your works turn to ash and dust if they do not serve the Omnissiah",
                        "Heresy grows from idleness",
                        "Thy soul, consumed with anger, shall be blinded to the unseen enemy",
                        "Heed not the smith, in his artifice lies thy doom",
                        "As thee began, so shalt thee end",

                    };
                    break;

                default:
                    character.faction.divinations = new List<String>()
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
                        "Only in death does duty end",
                        "Death is the servant of the righteous",
                        "Succes is commemorated; failure is merely remembered",
                        "Mercy is a sign of weakness",
                        "Innocence proves nothing",
                        "Blessed is the mind too small for doubt",
                        "Burn the Unclean with the fires of Purity",
                        "A coward always seeks compromise",
                        "Turn from the Emperor's light at your peril",
                        "There is nothing to fear but failure",
                        "Doubt is a sign of weakness",
                        "The greatest armor is contempt",
                        "The justice of your action is measured by the strength of your conviction",
                        "Hatred is the Emperor's greatest gift to Humanity",
                        "Doubt forms the path to damnation",
                        "Violence solves everything",
                        "Suffering is an unrelenting instructor",
                        "The Emperor will judge you not by your medals, but by your scars",
                        "Hope is the first step on the road to disappointment",
                        "Forgiveness is a sign of weakness",
                        "Do not ask why you serve, only ask how",
                        "All your works turn to ash and dust if they do not serve the Emperor",
                        "There are no bystanders in war, only soldiers and traitors",
                        "Carry the Emperor's Will as your torch; with it destroy the shadows",
                        "Heresy grows from idleness",
                        "Burn the Heretic! Kill the Mutant! Purge the Unclean!",
                        "Death sings sweetly",
                        "Thy soul, consumed with anger, shall be blinded to the unseen enemy",
                        "Heed not the smith, in his artifice lies thy doom",
                        "Beware the verdant depths, within doth lie disaster",
                        "The laurel wreath hides a poison thorn",
                        "Beware the purse, the sack, the velvet bag",
                        "Beware the young, the child, even the babe",
                        "As thee began, so shalt thee end",
                        "An ill reputation shall an ill man make",
                        "Tie not the ribbon, nor the feather; the peacock is thine enemy"
                    };
                    break;
            }
            return character;

        }
    }
}
