namespace CompositePattern
{
    internal class Recipe : IStep // Composite
    {
        private readonly string _name;
        private readonly List<IStep> _steps = new();

        public Recipe(string name)
        {
            _name = name;
        }

        public void Add(IStep step) // add()
        {
            _steps.Add(step);
        }

        public void Remove(IStep step) // remove()
        {
            _steps.Remove(step);
        }

        public void Run() // operation()
        {
            Console.WriteLine($"Running Recipe {_name}!");

            foreach (var step in _steps)
            {
                step.Run();
                Thread.Sleep(500); // to simulate movement
            }

            Console.WriteLine($"Recipe {_name} finished!");
        }
    }
}
