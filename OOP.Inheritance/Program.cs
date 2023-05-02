using OOP.Inheritance;

var _rectangle = new Rectangle(10,20,30,40);
var _circle = new Circle(50,60,70,80);
var _triangle = new Triangle(20,20,20,20);

Console.WriteLine("Triangle :   " + _triangle);
Console.WriteLine("Circle   :   " + _circle);
Console.WriteLine("Rectangle:   " + _rectangle);

_triangle.Draw();
_circle.Draw();
_rectangle.Draw();

new Rectangle(10, 20, 30, 40).Draw(); //Constructor ile aşırı yükleyerek tanımlama esnasında verilen değerleri override edilen method ile yazdırmak.

var shapes = new List<Shape>() {
    new Rectangle(10,20,30,40),
    new Triangle(50,60,70,80),
    new Circle(90,100,110,120),
    new Square(130,140,150,160),
};

Console.WriteLine("---------- List<Shape>(); ----------");

foreach (Shape shape in shapes)
{
    Console.WriteLine(shape);
    shape.Draw();
}

Console.WriteLine("---------- base keyword ----------");

var baseKeyword = new Rectangle(10, 20);

Console.WriteLine("{0} , {1}",baseKeyword.X, baseKeyword.Y);

//Sealed keyword: Tanımlandığı class ya da methodu kalıtımla devralınamaz hale getirir, mühürler.

//is ve as operatörleri.

var isAndAs = new Shape();
isAndAs.WorkWithDifferentObjects(23);