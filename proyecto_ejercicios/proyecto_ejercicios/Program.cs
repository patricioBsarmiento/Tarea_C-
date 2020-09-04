using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(200 + 56);
            Console.WriteLine(13 * 12);
            Console.WriteLine(321 - 213);
            Console.WriteLine((20 + 5) % 6);

            int a, b, c, d, numero1, numero2, n1, n2, e, f, g, h, i, j, k;
            a = 12;
            b = 102;
            c = 200;
            d = 1111;
            numero1 = 10;
            numero2 = 25;
            Console.WriteLine(a * b);
            Console.WriteLine(c * d);
            Console.WriteLine(numero1 * numero2);
            Console.WriteLine("Introduce el primer número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n1 * n2);
            Console.WriteLine("Introduce un número para verificar si es par: ");
            e = Convert.ToInt32(Console.ReadLine());

            if (e % 2 == 0)
                Console.WriteLine("El número ingresado es Par!! ");
            else
                Console.WriteLine("El numero NO es par ");
            Console.WriteLine("Introduce un número: ");

            f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número: ");
            g = Convert.ToInt32(Console.ReadLine());

            if (f > g) Console.WriteLine("El primer número es mayor");
            else Console.WriteLine("{El segundo número es mayor");

            Console.WriteLine("Introduce un número: ");
            h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro número: ");
            i = Convert.ToInt32(Console.ReadLine());

            if (i != 0) Console.WriteLine(h / i);

            else Console.WriteLine("ERROR!! No se puede dividir por 0");

            Console.WriteLine("Ingrese un numero entre el 1 y 5");
            j = Convert.ToInt32(Console.ReadLine());
            switch (j)
            {
                case 1:
                    Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("Dos");
                    break;
                case 3:
                    Console.WriteLine("Tres");
                    break;
                case 4:
                    Console.WriteLine("Cuatro");
                    break;
                case 5:
                    Console.WriteLine("Cinco");
                    break;

                default:
                    Console.WriteLine("El numero ingresado esta fuera de rango");
                    break;
            }

            k = 1;
            while (k < 11)
            {
                Console.WriteLine(k);
                k = k + 1;
            }
            int l = 1;
            do
            {
                Console.WriteLine(l);
                l = l + 1;
            }
            while (l < 11);

            int contador;
            for (contador = 10; contador <= 20; contador = contador + 1)
            {
                Console.WriteLine(contador);
            }
            Console.ReadLine();
        }
    }
}
