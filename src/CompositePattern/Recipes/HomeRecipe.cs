namespace CompositePattern.Recipes;

internal class HomeRecipe : Recipe
{
    private const int SlowJogSpeed = 10;
    private const int FastJogSpeed = 100;

    public HomeRecipe(IAxisFactory axisFactory) : base(nameof(HomeRecipe), axisFactory)
    {
        _steps = new List<IStep>()
        {
            new Steps.MoveRelativeStep(_gantry, -10000, FastJogSpeed),
            new Steps.MoveRelativeStep(_gantry, -100, FastJogSpeed),
            new Steps.MoveRelativeStep(_gantry, 10000, SlowJogSpeed),
            new Steps.SetHomeStep(_gantry),

            new Steps.MoveRelativeStep(_tray1, -10000, FastJogSpeed),
            new Steps.MoveRelativeStep(_tray1, -100, FastJogSpeed),
            new Steps.MoveRelativeStep(_tray1, 10000, SlowJogSpeed),
            new Steps.SetHomeStep(_tray1),

            new Steps.MoveRelativeStep(_tray2, -10000, FastJogSpeed),
            new Steps.MoveRelativeStep(_tray2, -100, FastJogSpeed),
            new Steps.MoveRelativeStep(_tray2, 10000, SlowJogSpeed),
            new Steps.SetHomeStep(_tray2),

            new Steps.MoveRelativeStep(_piston, -10000, FastJogSpeed),
            new Steps.MoveRelativeStep(_piston, -100, FastJogSpeed),
            new Steps.MoveRelativeStep(_piston, 10000, SlowJogSpeed),
            new Steps.SetHomeStep(_piston),

            new Steps.MoveRelativeStep(_needle, -10000, FastJogSpeed),
            new Steps.MoveRelativeStep(_needle, -100, FastJogSpeed),
            new Steps.MoveRelativeStep(_needle, 10000, SlowJogSpeed),
            new Steps.SetHomeStep(_needle),
        };
    }
}
