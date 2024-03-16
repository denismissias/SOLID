namespace SOLID.ISP
{
    public interface IMachine
    {
        void Fax(Document d);
        void Print(Document d);
        void Scan(Document d);
    }
}