using CompositePattern.Axes;

namespace CompositePattern.Steps;

internal class MoveRelativeStep : IStep
{
    private readonly int _amount;
    private readonly int _speed;
    private readonly IAxis _axis;

    public MoveRelativeStep(IAxis axis, int amount, int speed)
    {
        _axis = axis;
        _amount = amount;
        _speed = speed;
    }

    public void Run()
    {
        Console.WriteLine($"{nameof(MoveRelativeStep)}: Moving axis {_axis.Name} by {_amount} at a speed of {_speed}");
        _axis.CurrentPosition += _amount;
    }
}
