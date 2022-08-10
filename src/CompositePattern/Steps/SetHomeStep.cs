using CompositePattern.Axes;

namespace CompositePattern.Steps;

internal class SetHomeStep : IStep // Leaf
{
    private readonly IAxis _axis;

    public SetHomeStep(IAxis axis)
    {
        _axis = axis;
    }

    public void Run()
    {
        Console.WriteLine($"{nameof(SetHomeStep)}: Setting axis {_axis.Name} home");
        _axis.CurrentPosition = 0;
    }
}
