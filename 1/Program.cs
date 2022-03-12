using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labal1
{
    internal class Program
    {
        class Address
        {
            public Address(string city, string street, int home) { this.city = city; this.street = street; this.home = home; }
            public void Print() => Console.WriteLine("Название: {0}\nПлощадь бассейна: {1}\nПротяженность: {2}", city, street, home);
            private string city = "none";
            private string street = "none";
            private int home = 0;

            public string City
            {
                get { return city; }
                set { city = value; }
            }
            public string Street
            {
                get { return street; }
                set { street = value; }
            }
            public int Home
            {
                get { return home; }
                set { home = value; }
            }
        }

        static void Main(string[] args)
        {
            Address first = new Address("Полота", "325245", 4356356);
            first.Print(); 
            Console.ReadKey();
        }
    }
}
