using CK3AIGenerator.Domain.Models;

namespace CK3AIGenerator.Domain.Synergies;

public sealed class NoCraven : ISynergy
{
    public IEnumerable<IStrategy> GetStrategies()
    {
        yield return null;
    }
}