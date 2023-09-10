namespace SOLID_Principles.Liskov_Substitution;

public class Solution
{
    public class Rectangle
    {
        public virtual int Height { get; set; }
        public virtual int Width { get; set; }

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
        public override int Height
        {
            set
            {
                base.Height = base.Width = value;
            }
        }
        
        public override int Width
        {
            set
            {
                base.Width = base.Height = value;
            }
        }
    }
}