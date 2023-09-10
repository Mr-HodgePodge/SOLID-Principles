namespace SOLID_Principles.Interface_Segregation;

public class Solution
{
    public class Document
    {
        
    }

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public interface IFax
    {
        void Fax(Document d);
    }
    
    public class IMultiFunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;

        public IMultiFunctionDevice(IPrinter printer, IScanner scanner)
        {
            this.printer = printer ?? throw new ArgumentNullException(paramName: nameof(printer));
            this.scanner = scanner ?? throw new ArgumentNullException(paramName: nameof(scanner));
        }

        public void Print(Document d)
        {
            printer.Print(d);
        } //decorator pattern

        public void Scan(Document d)
        {
            scanner.Scan(d);
        }
    }

    public class Printer : IPrinter, IScanner
    {
        public void Print(Document d)
        {
            //exists
        }

        public void Scan(Document d)
        {
            //exists
        }
    }
}