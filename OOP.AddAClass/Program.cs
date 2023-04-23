
using OOP.AddAClass;

//Kapsülleme
Employee employee = new();
employee.FirstName = "Burak";
employee.LastName = "Karademir";
employee.Age = 23;
Console.WriteLine("Adı: " + employee.FirstName + "-- Soyadı: " + employee.LastName + "-- Yaşı: " + employee.Age);
//--------------------------------------------------------------------------------------------------------------------

//Constructor
Employee employee1 = new("Çağlar","Karahüseyin",27);
Console.WriteLine("Adı: " + employee1.FirstName + "-- Soyadı: " + employee1.LastName + "-- Yaşı: " + employee1.Age);
//--------------------------------------------------------------------------------------------------------------------

//Override ile ToString() methodu ezildi.
Employee employee2 = new("Ahmet","Karademir",48);
Console.WriteLine(employee2);
//--------------------------------------------------------------------------------------------------------------------

// Generic listede tutarak dönmek.
var list = new List<Employee>() 
{
    new Employee("Burak","Karademir",23),
    new Employee("Çağlar","Karahüseyin",27),
    new Employee("Ahmet","Karademir",48),
};

foreach (var item in list)
{
    Console.WriteLine(item);
}
//--------------------------------------------------------------------------------------------------------------------

//Method ile ekleme.

var employees = new Employee();
employees.Add(new Employee("Zafer","Cömert",38));
employees.AddRange(
    new Employee("Nurettin","Şenyer",40),
    new Employee("Köksal","Karademir",48)
    );

var listEmployee = employees.GetEmployees();
foreach (var item in listEmployee) 
{
    Console.WriteLine(item);
}
