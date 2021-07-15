namespace Iterator
{
    public interface IMyEnum
    {
        Person Curent { get; }
        Person MoveNext();
    }
}
