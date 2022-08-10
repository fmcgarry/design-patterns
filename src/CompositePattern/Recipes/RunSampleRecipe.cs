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

        AddStep(new GoToSampleRecipe(sampleNum, _axisFactory));
        AddStep(new PickupSampleRecipe());
        AddStep(new MoveAbsoluteStep(gantry, CellPosition)); // move to cell
        AddStep(new InjectSampleRecipe());
        AddStep(new MoveAbsoluteStep(gantry, CellPosition + 250)); // move out of the way
        AddStep(new RunTestRecipe());
    }
}
