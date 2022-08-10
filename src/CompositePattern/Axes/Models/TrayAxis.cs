namespace CompositePattern.Axes.Models;

internal class TrayAxis : IAxis
{
    public TrayAxis(int number)
    {
        Number = number;
        Name = $"Tray{number}";
    }

    public int CurrentPosition { get; set; }
    public bool IsEnabled { get; set; }
    public bool IsHomed { get; set; }
    public int Number { get; }
    public string Name { get; }
}
