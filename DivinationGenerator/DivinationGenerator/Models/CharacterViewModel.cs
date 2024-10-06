namespace DivinationGenerator.Models
{
    public class CharacterViewModel()
    {
        public int characterId { get; set; }
        public string? name { get; set; }
        public FactionViewModel faction { get; set; } = new FactionViewModel("Rogue Trader Dynasty");
        
        /*public CharacterViewModel()
        {

        }

        public CharacterViewModel(string factionName)
        {
            faction = new FactionViewModel(factionName);
        }*/
    }

}
