using CK3AIGenerator.Builder.LifestyleFocusChoice;
using CK3AIGenerator.Domain.Models;
using CK3AIGenerator.Domain.Traditions;

var builder = new LifestyleFocusSelection(new BaseFocusWeights(), new LifestyleFocusSelectionModifiers(new CharacterIf()), new List<ITradition>
{
    new ChansonDeGeste()
});
Console.WriteLine(builder.Build());