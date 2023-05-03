using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz8
{
    struct Vector3D
    {
        public double x;
        public double y;
        public double z;

        // Конструктор для ініціалізації вектора
        public Vector3D(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Метод для множення вектора на число
        public void Multiply(double scalar)
        {
            x *= scalar;
            y *= scalar;
            z *= scalar;
        }

        // Метод для додавання векторів
        public static Vector3D Add(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        // Метод для віднімання векторів
        public static Vector3D Subtract(Vector3D a, Vector3D b)
        {
            return new Vector3D(a.x - b.x, a.y - b.y, a.z - b.z);
        }
        public override string ToString() 
        {
            return string.Format($"{x},{y},{z}"); 
        }
    }

    internal class cs1
    {
        public static void task_1()
        {
            Vector3D Vector = new(1,2,3);
            Vector3D Vector_2 = new(4, 2, 1);

            Console.WriteLine("Vector 1: " + Vector.ToString());
            Console.WriteLine();

            Console.WriteLine("Vector 2: " + Vector_2.ToString());
            Console.WriteLine();

            Vector.Multiply(2);
            Console.WriteLine("Vector 1 after multiply: " + Vector.ToString());

            Vector3D sum = Vector3D.Add(Vector, Vector_2);
            Console.WriteLine();
            Console.WriteLine("Sum of vector 1 and vector 2: " + sum.ToString());

            Vector3D sub = Vector3D.Subtract(Vector, Vector_2);
            Console.WriteLine("Substract of vector 1 and vector 2: " + sub.ToString());
            Console.WriteLine();
        }
    }
}
