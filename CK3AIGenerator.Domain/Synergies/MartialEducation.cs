using CK3AIGenerator.Domain.Models;
using CK3AIGenerator.Domain.Strategies;

namespace CK3AIGenerator.Domain.Synergies;

public sealed class MartialEducation : ISynergy
{
    public IEnumerable<IStrategy> GetStrategies()
    {
        yield return new ChooseGallantIfMartial();
    }
}