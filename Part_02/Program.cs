using System;
using System.Security.Cryptography.X509Certificates;

namespace part_02
{
    class Program
    {
        static void Main()
        {
            Car cr1 = new Car();
            cr1.Name = "A";
            cr1.Engine = "V10";
            cr1.MaxSpeed = 210;
            Car cr2 = new Car();
            cr2.Name = "B";
            cr2.Engine = "W12";
            cr2.MaxSpeed = 230;
            Car cr3 = new Car();
            cr3.Name = "A";
            cr3.Engine = "V6";
            cr3.MaxSpeed = 180;

            Car[] list = new Car[] { cr1, cr2, cr3 };
            CarsCatalog crl = new CarsCatalog(list);
            int i = 1;
            Console.WriteLine(crl[i]);
        }

        public class CarsCatalog
        {
            Car[] list;

            public CarsCatalog(Car[] obj)
            {
                list = obj;
            }

            public string this[int index]
            {
                get
                {
                    string str = $"This is {list[index].Name}, and it have a {list[index].Engine} engine";
                    return str;
                }
            }
        }

        public struct Car : IEquatable<Car>
        {
            public string Name { get; set; }
            public string Engine { get; set; }
            public double MaxSpeed { get; set; }

            public override string ToString() => $"{Name}";

            bool IEquatable<Car>.Equals(Car other)
            {
                throw new NotImplementedException();
            }

            public override bool Equals(object? obj) => this == obj as Car?;
            public static bool operator ==(Car? left, Car? right) =>
            left?.Name == right?.Name && left?.Engine == right?.Engine && left?.MaxSpeed == right?.MaxSpeed;
            public static bool operator !=(Car? left, Car? right) => !(left == right);
        }
    }
}