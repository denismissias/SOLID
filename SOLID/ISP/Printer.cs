namespace SOLID.ISP
{
    public class Printer : IPrinter
    {
        public void Print(Document d)
        {
            Console.WriteLine("I'm printing a document");
        }
    }
}
