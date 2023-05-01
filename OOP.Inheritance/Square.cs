using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Square :Rectangle //Multi-level Inheritance
    {
        public Square(int x, int y, int heigth, int width)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = heigth;
        }

        new public void Calculate() //Burada method access modifier öncesi kullanılan new kalıtılan sınıftan gelen ve isimleri aynı olan iki methodun çakışmasını engellemek için kullanılır. Square'den çağırılacak Calculate methodu artık bu olacak.
        {

        }
        
    }
}
