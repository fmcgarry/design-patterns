namespace CompositePattern.Axes;

internal interface IAxis
{
    public int CurrentPosition { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsHomed { get; set; }
    public string Name { get; }
}