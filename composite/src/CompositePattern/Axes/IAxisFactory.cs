namespace CompositePattern.Axes
{
    internal interface IAxisFactory
    {
        IAxis Create(string name);
        void Register(IAxis axis);
    }
}