using System.CodeDom.Compiler;

namespace CK3AIGenerator.Builder;

public static class AiFileBuilderExtensions
{
    public static void AddBlock(this IndentedTextWriter textWriter, string blockTitle, Action code)
    {
        textWriter.WriteLine($"{blockTitle} = {{");
        textWriter.Indent++;
        code();
        textWriter.Indent--;
        textWriter.WriteLine('}');
    }
}