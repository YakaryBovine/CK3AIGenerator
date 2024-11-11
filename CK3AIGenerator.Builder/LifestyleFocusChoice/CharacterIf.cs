using System.CodeDom.Compiler;

namespace CK3AIGenerator.Builder.LifestyleFocusChoice;

public sealed class CharacterIf
{
    public void Build(IndentedTextWriter textWriter, Action limit, Action add)
    {
        textWriter.AddBlock("if", () =>
        {
            textWriter.AddBlock("limit", limit);
            textWriter.AddBlock("add", add);
        });
    }
}