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
