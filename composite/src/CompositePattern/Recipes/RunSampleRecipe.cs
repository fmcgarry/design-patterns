using CompositePattern.Axes;
using CompositePattern.Steps;

namespace CompositePattern.Recipes;

internal class RunSampleRecipe : Recipe
{
    private const int SlowJogSpeed = 10;
    private const int FastJogSpeed = 100;
    private const int CellPosition = 1000;

    private readonly IAxisFactory _axisFactory;

    public RunSampleRecipe(int sampleNum, IAxisFactory axisFactory) : base($"{nameof(RunSampleRecipe)}")
    {
        _axisFactory = axisFactory;

        IAxis gantry = _axisFactory.Create("Gantry");

        Add(new GoToSampleRecipe(sampleNum, _axisFactory));
        Add(new PickupSampleRecipe());
        Add(new MoveAbsoluteStep(gantry, CellPosition)); // move to cell
        Add(new InjectSampleRecipe());
        Add(new MoveAbsoluteStep(gantry, CellPosition + 250)); // move out of the way
        Add(new RunTestRecipe());
    }
}
