using CompositePattern.Axes;

namespace CompositePattern.Steps;

internal class MoveAbsoluteStep : IStep // Leaf
{
    private readonly int _position;
    private readonly IAxis _axis;

    public MoveAbsoluteStep(IAxis axis, int position)
    {
        _axis = axis;
        _position = position;
    }

    public void Run()
    {
        Console.WriteLine($"{nameof(MoveAbsoluteStep)}: Moving axis {_axis.Name} to {_position}");
        _axis.CurrentPosition = _position;
    }
}
