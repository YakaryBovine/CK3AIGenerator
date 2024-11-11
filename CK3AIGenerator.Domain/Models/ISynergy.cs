namespace CK3AIGenerator.Domain.Models;

public interface ISynergy
{
    public IEnumerable<IStrategy> GetStrategies();
}