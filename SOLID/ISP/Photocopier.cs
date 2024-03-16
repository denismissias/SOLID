namespace SOLID.ISP
{
    public class Photocopier : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            Console.WriteLine("I'm printing a document");
        }

        public void Scan(Document d)
        {
            Console.WriteLine("I'm scanning a document");
        }
    }
    {
    }
}
