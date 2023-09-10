namespace SOLID_Principles.Single_Responsibility;

public class Scenario
{
    public class Journal
    {
        private readonly List<String> entries = new List<string>();
        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count; //memento
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        public static Journal? Load(string filename)
        {
            return null;
        }

        public void Load(Uri uri)
        {
            
        }
    }
}