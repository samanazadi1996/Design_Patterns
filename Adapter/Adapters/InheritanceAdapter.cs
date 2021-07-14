namespace Adapter.Adapters
{
    public class InheritanceAdapter : PrintToScreen, Iprinter
    {
        public void Print(string input)
        {
            this.PrintText(input);
        }
    }
}
