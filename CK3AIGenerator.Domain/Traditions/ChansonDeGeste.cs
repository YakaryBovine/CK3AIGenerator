using CK3AIGenerator.Domain.Models;
using CK3AIGenerator.Domain.Synergies;

namespace CK3AIGenerator.Domain.Traditions;

public sealed class ChansonDeGeste : ITradition
{
    public string Key => "chanson_de_geste";

    public IEnumerable<ISynergy> GetSynergies()
    {
        yield return new MartialEducation();
        //yield return new NoContent();
        //yield return new NoCraven();
        //yield return new Knights();
    }
}