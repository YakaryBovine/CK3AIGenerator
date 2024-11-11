using System.CodeDom.Compiler;
using CK3AIGenerator.Domain.Models;

namespace CK3AIGenerator.Builder.LifestyleFocusChoice;

public sealed class LifestyleFocusSelection(
    BaseFocusWeights baseFocusWeights,
    LifestyleFocusSelectionModifiers lifestyleFocusSelectionModifiers,
    IEnumerable<ITradition> traditions)
{
    public string Build()
    {
        var textWriter = new IndentedTextWriter(new StringWriter(), "    ");
        textWriter.AddBlock("ai_lifestyle_focus_selection", () =>
        {
            baseFocusWeights.Build(textWriter);
            lifestyleFocusSelectionModifiers.Build(textWriter, traditions);
        });
        return textWriter.InnerWriter.ToString()!;
    }
}