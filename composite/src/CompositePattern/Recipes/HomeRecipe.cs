using CompositePattern.Axes;

namespace CompositePattern.Recipes
{
    internal class HomeRecipe : Recipe
    {
        private const int SlowJogSpeed = 10;
        private const int FastJogSpeed = 100;

        private IAxis _gantry;
        private IAxis _tray1;
        private IAxis _tray2;
        private IAxis _needle;
        private IAxis _piston;

        public HomeRecipe(IAxisFactory axisFactory) : base($"{nameof(HomeRecipe)}")
        {
            _gantry = axisFactory.Create("Gantry");
            _tray1 = axisFactory.Create("Tray1");
            _tray2 = axisFactory.Create("Tray2");
            _needle = axisFactory.Create("Needle");
            _piston = axisFactory.Create("Piston");

            AddRecipeSteps();
        }

        private void AddRecipeSteps()
        {
            Add(new Steps.MoveRelativeStep(_gantry, -10000, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_gantry, -100, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_gantry, 10000, SlowJogSpeed));
            Add(new Steps.SetHomeStep(_gantry));

            Add(new Steps.MoveRelativeStep(_tray1, -10000, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_tray1, -100, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_tray1, 10000, SlowJogSpeed));
            Add(new Steps.SetHomeStep(_tray1));

            Add(new Steps.MoveRelativeStep(_tray2, -10000, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_tray2, -100, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_tray2, 10000, SlowJogSpeed));
            Add(new Steps.SetHomeStep(_tray2));

            Add(new Steps.MoveRelativeStep(_piston, -10000, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_piston, -100, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_piston, 10000, SlowJogSpeed));
            Add(new Steps.SetHomeStep(_piston));

            Add(new Steps.MoveRelativeStep(_needle, -10000, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_needle, -100, FastJogSpeed));
            Add(new Steps.MoveRelativeStep(_needle, 10000, SlowJogSpeed));
            Add(new Steps.SetHomeStep(_needle));
        }
    }
}

