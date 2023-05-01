
public class Rectangle : Shape
{
    public Rectangle(int x, int y, int heigth, int width)
    {
        this.X = x;
        this.Y = y;
        this.Width = width;
        this.Height = heigth;
    }
    public Rectangle()
    {
        
    }

    public Rectangle(int x, int y) : base(x,y)
    {
        
    }

    public override string ToString()
    {
        return $"X:{X} Y: {Y} Heigth: {Height} Width: {Width}";
    }

    public override void Draw()
    {
        Console.WriteLine("Rectangle:   X:{0}     Y:{1}     Heigth:{2}     Width:{3}", X, Y, Height, Width);
    }

    public  void Calculate()
    {
        Console.WriteLine("Calculated by Rectangle...");
    }

}