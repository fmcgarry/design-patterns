using CompositePattern.Axes;

namespace CompositePattern.Recipes
{
    internal class Recipe : IStep
    {
        private readonly string _name;
        protected List<IStep> _steps = new();

        protected readonly IAxis _gantry;
        protected readonly IAxis _tray1;
        protected readonly IAxis _tray2;
        protected readonly IAxis _needle;
        protected readonly IAxis _piston;

        public Recipe(string name, IAxisFactory axisFactory)
        {
            _name = name;

            _gantry = axisFactory.Create("Gantry");
            _tray1 = axisFactory.Create("Tray1");
            _tray2 = axisFactory.Create("Tray2");
            _needle = axisFactory.Create("Needle");
            _piston = axisFactory.Create("Piston");
        }

        public void Run()
        {
            if (_steps.Count == 0)
            {
                throw new Exception($"No steps found in recipe {_name}");
            }

            foreach (var step in _steps)
            {
                step.Run();
                Thread.Sleep(500); // to simulate movement
            }

            Console.WriteLine($"Recipe {_name} finished!");
        }
    }
}
