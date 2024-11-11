using System.CodeDom.Compiler;

namespace CK3AIGenerator.Builder.LifestyleFocusChoice;

public sealed class BaseFocusWeights
{
    public void Build(IndentedTextWriter textWriter)
    {
        textWriter.AddBlock("base_focus_weights", () =>
        {
            textWriter.WriteLine("diplomacy_lifestyle = 0");
            textWriter.WriteLine("martial_lifestyle = 0");
            textWriter.WriteLine("stewardship_lifestyle = 0");
            textWriter.WriteLine("intrigue_lifestyle = 0");
            textWriter.WriteLine("learning_lifestyle = 0");
        });
    }
}