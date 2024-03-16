namespace SOLID
{
    public class Journal
    {
        private readonly List<string> entries = new();
        private static int count = 0;

        public void AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}
