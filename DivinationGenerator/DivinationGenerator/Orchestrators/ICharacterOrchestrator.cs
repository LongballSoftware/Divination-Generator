using DivinationGenerator.Models;

namespace DivinationGenerator.Orchestrators
{
    public abstract class ICharacterOrchestrator
    {
        public abstract CharacterViewModel UpdateFaction(CharacterViewModel character, string factionName);
    }
}
