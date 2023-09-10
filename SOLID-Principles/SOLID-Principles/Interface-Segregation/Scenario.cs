namespace SOLID_Principles.Interface_Segregation;

public class Scenario
{
    public class Document
    {
        
    }

    public interface IMachine
    {
        void Print(Document d);
        void Scan(Document d);
        void Fax(Document d);
    }

    public class MultifunctionPrinter : IMachine
    {
        public void Print(Document d)
        {
            //exists
        }

        public void Scan(Document d)
        {
            //exists
        }

        public void Fax(Document d)
        {
            //exists
        }
    }

    public class OldFashionedPrinter : IMachine
    {
        public void Print(Document d)
        {
            //exists
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }

        public void Fax(Document d)
        {
            throw new NotImplementedException();
        }
    }
}