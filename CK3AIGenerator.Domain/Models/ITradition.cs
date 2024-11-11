namespace CK3AIGenerator.Domain.Models;

public interface ITradition
{
    public string Key { get; }

    public IEnumerable<ISynergy> GetSynergies();
}