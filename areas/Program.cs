using System;

namespace areas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char objeto, continuar = 'S';
            double num1, num2, resultado1, resultado2;
            bool n1, n2;
            while (continuar == 'S')
            {
                objeto = 'a';
                num1 = 0;
                num2 = 0;
                n1 = true;
                n2 = true;

                Console.WriteLine("Elije una figura de las siguientes opciones");
                Console.WriteLine("<C>uadrado");
                Console.WriteLine("<R>extangulo");
                Console.WriteLine("<T>riangulo");
                Console.WriteLine("C<i>rculo");
                while (objeto != 'C' && objeto != 'R' && objeto != 'T' && objeto != 'I')
                {
                    try
                    {
                        objeto = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                    }
                    catch
                    {
                        Console.WriteLine("Solamente pon un caracter");
                    }
                }

                if (objeto == 'T')
                {
                    Console.WriteLine("Ingresa la base");
                    while (n1)
                    {
                        try
                        {
                            n1 = false;
                            num1 = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            n1 = true;
                            Console.WriteLine("Ingresa un numero");
                        }
                    }
                    Console.WriteLine("Ingresa su altura");
                    while (n2)
                    {
                        try
                        {
                            n2 = false;
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            n2 = true;
                            Console.WriteLine("Ingresa un numero");
                        }
                    }
                }
                else if (objeto == 'I')
                {
                    Console.WriteLine("Ingresa el radio");
                    while (n1)
                    {
                        try
                        {
                            n1 = false;
                            num1 = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            n1 = true;
                            Console.WriteLine("Ingresa un numero");
                        }
                    }
                }
                else if (objeto == 'R')
                {
                    Console.WriteLine("Ingresa la base");
                    while (n1)
                    {
                        try
                        {
                            n1 = false;
                            num1 = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            n1 = true;
                            Console.WriteLine("Ingresa un numero");
                        }
                    }
                    Console.WriteLine("Ingresa su altura");
                    while (n2)
                    {
                        try
                        {
                            n2 = false;
                            num2 = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            n2 = true;
                            Console.WriteLine("Ingresa un numero");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Ingresa un lado");
                    while (n1)
                    {
                        try
                        {
                            n1 = false;
                            num1 = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            n1 = true;
                            Console.WriteLine("Ingresa un numero");
                        }
                    }
                }

                switch (objeto)
                {
                    case 'C':
                        resultado1 = num1 * num1;
                        resultado2 = num1 * 4;
                        Console.WriteLine("El area es: " + resultado1);
                        Console.WriteLine("El perimetro es: " + resultado2);
                        break;

                    case 'R':
                        resultado1 = num1 * num2;
                        resultado2 = num1 + num2 + num1 + num2;
                        Console.WriteLine("El area es: " + resultado1);
                        Console.WriteLine("El perimetro es: " + resultado2);
                        break;

                    case 'T':
                        resultado1 = (num1 * num2) / 2;
                        resultado2 = num1 * 3;
                        Console.WriteLine("El area es: " + resultado1);
                        Console.WriteLine("El perimetro es: " + resultado2);
                        break;

                    case 'I':
                        resultado1 = num1 * num1 * 3.1416;
                        resultado2 = num1 * 2 * 3.1416;
                        Console.WriteLine("El area es: " + resultado1);
                        Console.WriteLine("El perimetro es: " + resultado2);
                        break;
                    default:
                        Console.WriteLine("Esto nunca devio de aparecer");
                        return;
                }
                Console.WriteLine("Programa finalizado con exito. ¿Quieres hacer otra operacion?(S/N)");
                while (true)
                {
                    try
                    {
                        continuar = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                        if (continuar == 'S' || continuar == 'N')
                        {
                            break;
                        }
                        Console.WriteLine("S/N");
                    }
                    catch
                    {
                        Console.WriteLine("Solamente pon un caracter");
                    }
                }
            }
        }
    }
}
