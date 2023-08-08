using CompositePattern.Axes.Models;

namespace CompositePattern.Axes
{
    internal class AxisFactory : IAxisFactory
    {
        private readonly List<IAxis> _axes = new();

        public IAxis Create(string name)
        {
            IAxis? axis = _axes.Find(x => x.Name == name);

            if (axis is null)
            {
                axis = name switch
                {
                    "Gantry" => new GantryAxis(),
                    "Needle" => new NeedleAxis(),
                    "Piston" => new PistonAxis(),
                    "Tray1" => new TrayAxis(1),
                    "Tray2" => new TrayAxis(2),
                    _ => throw new NotImplementedException($"Axis {name} not found")
                };

                _axes.Add(axis);
            }

            return axis;
        }

        public void Register(IAxis axis)
        {
            _axes.Add(axis);
        }
    }
}
