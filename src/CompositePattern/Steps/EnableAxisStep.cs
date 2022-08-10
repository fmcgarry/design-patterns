using CompositePattern.Axes;

namespace CompositePattern.Steps;

internal class EnableAxisStep : IStep // Leaf
{
    private readonly IAxis _axis;

    public EnableAxisStep(IAxis axis)
    {
        _axis = axis;
    }

    public void Run()
    {
        Console.WriteLine($"{nameof(EnableAxisStep)}: Enabling axis {_axis.Name}");
        _axis.IsEnabled = true;
    }
}
