namespace part_01
{
    class Program
    {
        static void Main()
        {
            Vector obj1 = new Vector(1, 2, 3);
            Vector obj2 = new Vector(3, 4, 5);

            Vector obj3 = obj1 + obj2;
            int obj4 = obj1 * obj2;
            Vector obj5 = obj1 * 10;

            Console.WriteLine($"{obj3.x} {obj3.y} {obj3.z}");
            Console.WriteLine(obj4);
            Console.WriteLine($"{obj5.x} {obj5.y} {obj5.z}");
        }

        public class Vector
        {
            public int x, y, z;

            public Vector (int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public static Vector operator +(Vector a, Vector b)
            {
                return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
            }

            public static Vector operator *(Vector a, int b)
            {
                return new Vector(a.x * b, a.y * b, a.z * b);
            }

            public static int operator *(Vector a, Vector b)
            {
                int obj = (a.x*b.x)+(a.y*b.y)+(a.z*b.z);
                return obj;
            }

            public static bool operator &(Vector obj1, Vector obj2)
            {
                if (((obj1.x != 0) | (obj1.y != 0) | (obj1.z != 0))
                    & ((obj2.x != 0) | (obj2.y != 0) | (obj2.z != 0)))
                    return true;
                return false;
            }

            public static bool operator |(Vector obj1, Vector obj2)
            {
                if (((obj1.x != 0) | (obj1.y != 0) | (obj1.z != 0))
                    | ((obj2.x != 0) | (obj2.y != 0) | (obj2.z != 0)))
                    return true;
                return false;
            }

            public static bool operator ^(Vector obj1, Vector obj2)
            {
                if ((((obj1.x != 0) | (obj1.y != 0) | (obj1.z != 0))
                    & ((obj2.x == 0) | (obj2.y == 0) | (obj2.z == 0))) | (((obj1.x == 0) && (obj1.y == 0) && (obj1.z == 0))
                    & ((obj2.x != 0) | (obj2.y != 0) | (obj2.z != 0))))
                    return true;
                return false;
            }
        }
    }
}