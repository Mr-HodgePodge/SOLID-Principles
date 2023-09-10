namespace SOLID_Principles.Open_Closed;

public class Solution
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

    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }

    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }

    public class ColourSpecification : ISpecification<Product>
    {
        private Colour colour;

        public ColourSpecification(Colour colour)
        {
            this.colour = colour;
        }
        
        public bool IsSatisfied(Product p)
        {
            return p.Colour == colour;
        }
    }

    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product p)
        {
            return p.Size == size;
        }
    }

    public class AndSpecification<T> : ISpecification<T>
    {
        private ISpecification<T> first, second;
        
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            this.first = first ?? throw new ArgumentNullException(paramName: nameof(first));
            this.second = second ?? throw new ArgumentNullException(paramName: nameof(second));
        }

        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }

    public class BetterFilter : IFilter<Product>
    {
        public IEnumerable<Product> Filter(IEnumerable<Product> items, ISpecification<Product> spec)
        {
            foreach (var item in items)
            {
                if (spec.IsSatisfied(item))
                    yield return item;
            }
        }
    }
}