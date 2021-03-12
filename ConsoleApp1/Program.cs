using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] a = new char[3, 3];
            for (int f = 0; f < 3; f++)
            {
                for (int g = 0; g < 3; g++)
                {
                    a[f, g] = '-';
                }
            }
            bool d = true, e=true;
            char t='O';
            int b,c;
            while (e)
            {
                if (d)
                    Console.WriteLine("intro las coordenadas de su posicion para el jugador 1(O)(x=1-3 & y=1-3):");
                              
                else        
                    Console.WriteLine("intro las coordenadas de su posicion para el jugador 1(X)(x=1-3 & y=1-3):");                
                c = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
                if (c <= 3 && c >= 1 && b <= 3 && b >= 1)
                {
                    if (a[b - 1, c - 1] == '-')
                    {
                        if (d)
                        {
                            t = 'O';
                            d = false;
                        }
                        else
                        {
                            t = 'X';
                            d = true;
                        }
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (i == b - 1 && j == c - 1)
                                    a[i, j] = t;
                                Console.Write(a[i, j] + "  ");
                            }
                            Console.WriteLine(" ");
                        }
                        if (a[0, 0] == 'O' && a[0, 1] == 'O' && a[0, 2] == 'O')
                            e = false;
                        if (a[0, 0] == 'O' && a[1, 0] == 'O' && a[2, 0] == 'O')
                            e = false;
                        if (a[0, 1] == 'O' && a[1, 1] == 'O' && a[2, 1] == 'O')
                            e = false;
                        if (a[1, 0] == 'O' && a[1, 1] == 'O' && a[1, 2] == 'O')
                            e = false;
                        if (a[0, 2] == 'O' && a[1, 2] == 'O' && a[2, 2] == 'O')
                            e = false;
                        if (a[2, 0] == 'O' && a[2, 1] == 'O' && a[2, 2] == 'O')
                            e = false;
                        if (a[0, 0] == 'O' && a[1, 1] == 'O' && a[2, 2] == 'O')
                            e = false;
                        if (a[2, 0] == 'O' && a[1, 1] == 'O' && a[0, 2] == 'O')
                            e = false;

                        if (a[0, 0] == 'X' && a[0, 1] == 'X' && a[0, 2] == 'X')
                            e = false;
                        if (a[0, 0] == 'X' && a[1, 0] == 'X' && a[2, 0] == 'X')
                            e = false;
                        if (a[0, 1] == 'X' && a[1, 1] == 'X' && a[2, 1] == 'X')
                            e = false;
                        if (a[1, 0] == 'X' && a[1, 1] == 'X' && a[1, 2] == 'X')
                            e = false;
                        if (a[0, 2] == 'X' && a[1, 2] == 'X' && a[2, 2] == 'X')
                            e = false;
                        if (a[2, 0] == 'X' && a[2, 1] == 'X' && a[2, 2] == 'X')
                            e = false;
                        if (a[0, 0] == 'X' && a[1, 1] == 'X' && a[2, 2] == 'X')
                            e = false;
                        if (a[2, 0] == 'X' && a[1, 1] == 'X' && a[0, 2] == 'X')
                            e = false;

                    }
                    else
                    {
                        Console.WriteLine("Esa casilla esta ocupada");
                    }
                }
                else
                {
                    Console.WriteLine("Esa casilla esta fuera de rango");
                }
            }
            Console.Write("termino el juego gano ");
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
