namespace CompositePattern.Axes.Models;

internal class NeedleAxis : IAxis
{
    public int CurrentPosition { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsHomed { get; set; }
    public string Name => "Needle";
}
