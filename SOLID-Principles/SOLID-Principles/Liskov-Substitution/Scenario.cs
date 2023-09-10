namespace SOLID_Principles.Liskov_Substitution;

public class Scenario
{
    public class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }

        public Rectangle()
        {
            
        }

        public Rectangle(int height, int weight)
        {
            Height = height;
            Width = weight;
        }

        public override string ToString()
        {
            return $"{nameof(Height)}: {Height}, {nameof(Width)}: {Width}";
        }
    }

    public class Square : Rectangle
    {
        public new int Height
        {
            set
            {
                base.Height = base.Width = value;
            }
        }
        
        public new int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }
    }
}