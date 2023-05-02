
public class Shape
{
    public Shape(int x, int y)
    {
        X = x;
        Y = y;
    }
    public Shape()
    {
        
    }

    public int X { get; set; }
    public int Y { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }

    public virtual void Draw() // Virtual : Kalıtılacağı sınıfda ezilebileceği özelliğini verir.
    {
        System.Console.WriteLine("Draw");
    }

    public void WorkWithDifferentObjects(object obj)
    {
        Shape shapeFromParameter = obj as Shape; //as öperatörü gelen objenin Shape olabilme durumunu kontrol eder ve eğer olursa aktarır. Gerçekleşmezse null aktarır.
        if (shapeFromParameter is null) 
        {
            Console.WriteLine("Null!");
        }
        else
        {
            shapeFromParameter.Draw();
        }
    }

}
