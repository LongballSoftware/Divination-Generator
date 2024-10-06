namespace DivinationGenerator.Models
{
    public class CharacterViewModel
    {
        public int characterId { get; set; }
        public string? name { get; set; }
        public FactionViewModel faction { get; set; }
        
        public CharacterViewModel() 
        { 
            faction = new FactionViewModel("");
        }

        public CharacterViewModel(string factionName)
        {
            faction = new FactionViewModel(factionName);
        }
    }

}
