using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AddAClass
{
    internal class Employee
    {
        //Encapsulation - Kapsülleme : Diğer nesnelerle belirli kurallar dahilinde veri alışverişi yapmamıza olanak tanır.

        private string _firstName;  //Field
        private string _lastName;
        private List<Employee> _list;
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }

        //Code snippet (prop) : property oluşturarak auto-implemented olarak tanımlayabiliriz. Böylece get ve set bloklarının özel bir işlevi olmadıkça bu yöntem kullanılabilir.
        public int Age { get; set; }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        /*Constructor : Yapılandırıcı method. Code snippet : ctor. Method'u aşırı yükleyerek 2 farklı yapılandırıcı durum ekledik. Artık program class'ında newleme işlemi esnasında
        gerekli değerleri verebiliriz.*/

        public Employee() //Program classında employee nesnesi boş olarak türetildiği için boş yapılandırıcı method da burada bulunmalıdır.
        {
            _list = new List<Employee>();
        }
        public Employee(string FirstName, string LastName, int Age)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this.Age = Age;
            _list = new List<Employee>();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        //Override. ToString() methodunu ezerek artık nesneyi türettiğimde adını vererek içeriğini yazdırma imkanı sağlıyorum.
        public override string ToString()
        {
            return $"{FirstName,-20} {LastName,-20} {Age,5}";
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------

        //Method ile Listeye değer alma ve params keyword. params : bir methodun değişken sayıda argüman alabileceğini belirtir.
        public void Add(Employee employee) 
        {
            _list.Add(employee);
        }

        public void AddRange(params Employee[] employees) 
        {
            _list.AddRange(employees);
        }

        public List<Employee> GetEmployees() => _list;
    }
}
