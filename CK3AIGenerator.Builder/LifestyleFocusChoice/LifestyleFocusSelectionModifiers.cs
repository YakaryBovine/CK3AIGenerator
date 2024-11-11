using System.CodeDom.Compiler;
using CK3AIGenerator.Domain.Models;

namespace CK3AIGenerator.Builder.LifestyleFocusChoice;

public sealed class LifestyleFocusSelectionModifiers(CharacterIf characterIf)
{
    public void Build(IndentedTextWriter textWriter, IEnumerable<ITradition> traditions)
    {
        textWriter.AddBlock("modifiers", () =>
        {
            foreach (var tradition in traditions)
            {
                foreach (var synergy in tradition.GetSynergies())
                {
                    foreach (var strategy in synergy.GetStrategies())
                    {
                        characterIf.Build(textWriter, () =>
                        {
                            textWriter.WriteLine($"has_cultural_tradition = {tradition.Key}");
                            textWriter.WriteLine(strategy.Limits());
                        }, () =>
                        {
                            textWriter.WriteLine(strategy.Adds());
                        });
                    }
                }
            }
        });
    }
}