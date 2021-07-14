namespace Adapter.Adapters
{
    public class ObjectAdapter : Iprinter
    {
        private readonly PrintToScreen printToScreen;
        public ObjectAdapter()
        {
            printToScreen = new PrintToScreen();
        }

        public void Print(string input)
        {
            printToScreen.PrintText(input);
        }
    }
}
