using CompositePattern.Axes;
using CompositePattern.Steps;

namespace CompositePattern.Recipes;

internal class GoToSampleRecipe : Recipe
{
    private readonly int _samplePositionX;
    private readonly int _samplePositionY;
    private readonly IAxisFactory _axisFactory;

    public GoToSampleRecipe(int sampleNum, IAxisFactory axisFactory) : base($"{nameof(GoToSampleRecipe)}")
    {
        _axisFactory = axisFactory;
        _samplePositionX = CalculateSamplePositionX(sampleNum);
        _samplePositionY = CalculateSamplePositionY(sampleNum);

        AddRecipeSteps();
    }

    private static int CalculateSamplePositionX(int sampleNum)
    {
        return 1;
    }

    private static int CalculateSamplePositionY(int sampleNum)
    {
        return 2;
    }

    private void AddRecipeSteps()
    {
        IAxis gantry = _axisFactory.Create("Gantry");
        IAxis tray1 = _axisFactory.Create("Tray1");

        Add(new MoveAbsoluteStep(gantry, _samplePositionX));
        Add(new MoveAbsoluteStep(tray1, _samplePositionY));
    }
}
