using CK3AIGenerator.Domain.Constants;
using CK3AIGenerator.Domain.Models;

namespace CK3AIGenerator.Domain.Strategies;

public sealed class ChooseGallantIfMartial : IStrategy
{
    public string Limits()
    {
        return "has_education_trait = martial_education";
    }

    public string Adds()
    {
        return $"martial_lifestyle_focus = {LifestyleFocuses.Gallant}";
    }
}