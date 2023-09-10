namespace SOLID_Principles.Open_Closed;

public class Scenario
{
    public enum Colour
    {
        Red, Green, Blue
    }

    public enum Size
    {
        Small, Medium, Large
    }

    public class Product
    {
        public string Name;
        public Colour Colour;
        public Size Size;

        public Product(string name, Colour colour, Size size)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Colour = colour;
            Size = size;
        }
    }

    public class ProductFilter
    {
        public IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Size size)
        {
            foreach (var p in products)
            {
                if (p.Size == size)
                {
                    yield return p;
                }
            }
        }
        
        public IEnumerable<Product> FilterByColour(IEnumerable<Product> products, Colour colour)
        {
            foreach (var p in products)
            {
                if (p.Colour == colour)
                {
                    yield return p;
                }
            }
        }
        
        public IEnumerable<Product> FilterBySizeAndColour(IEnumerable<Product> products, Size size, Colour colour)
        {
            foreach (var p in products)
            {
                if (p.Colour == colour && p.Size == size)
                {
                    yield return p;
                }
            }
        }
    }
}