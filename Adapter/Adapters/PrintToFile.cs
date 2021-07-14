namespace Adapter.Adapters
{
    public class PrintToFile : Iprinter
    {
        public void Print(string input)
        {
            System.IO.File.WriteAllText("C://1.txt", input);
        }
    }
}
