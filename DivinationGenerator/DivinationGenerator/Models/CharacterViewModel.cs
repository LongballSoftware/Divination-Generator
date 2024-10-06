namespace DivinationGenerator.Models
{
    public class CharacterViewModel
    {
        public string? name { get; set; }
        public FactionViewModel faction { get; set; }
        
        

        public CharacterViewModel(string factionName)
        {
            faction = new FactionViewModel(factionName);
        }

        public CharacterViewModel()
        {
            faction = new FactionViewModel("");
        }
    }

}
