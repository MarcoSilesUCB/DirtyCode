using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Juego
    {
        //COMPRUEBA LAS DIFERENTES CONDICIONES PARA GANA EN EL 'TRES EN RAYA'
        //(Cambio a una nueva funcion, que verifica las codiciones para ganar el juego)
        static bool condicionGanar(char[,] matriz)
        {
            bool res=true;
            
            if (matriz[0, 0] == 'O' && matriz[0, 1] == 'O' && matriz[0, 2] == 'O')
                res = false;
            if (matriz[0, 0] == 'O' && matriz[1, 0] == 'O' && matriz[2, 0] == 'O')
                res = false;
            if (matriz[0, 1] == 'O' && matriz[1, 1] == 'O' && matriz[2, 1] == 'O')
                res = false;
            if (matriz[1, 0] == 'O' && matriz[1, 1] == 'O' && matriz[1, 2] == 'O')
                res = false;
            if (matriz[0, 2] == 'O' && matriz[1, 2] == 'O' && matriz[2, 2] == 'O')
                res = false;
            if (matriz[2, 0] == 'O' && matriz[2, 1] == 'O' && matriz[2, 2] == 'O')
                res = false;
            if (matriz[0, 0] == 'O' && matriz[1, 1] == 'O' && matriz[2, 2] == 'O')
                res = false;
            if (matriz[2, 0] == 'O' && matriz[1, 1] == 'O' && matriz[0, 2] == 'O')
                res = false;
            if (matriz[0, 0] == 'X' && matriz[0, 1] == 'X' && matriz[0, 2] == 'X')
                res = false;
            if (matriz[0, 0] == 'X' && matriz[1, 0] == 'X' && matriz[2, 0] == 'X')
                res = false;
            if (matriz[0, 1] == 'X' && matriz[1, 1] == 'X' && matriz[2, 1] == 'X')
                res = false;
            if (matriz[1, 0] == 'X' && matriz[1, 1] == 'X' && matriz[1, 2] == 'X')
                res = false;
            if (matriz[0, 2] == 'X' && matriz[1, 2] == 'X' && matriz[2, 2] == 'X')
                res = false;
            if (matriz[2, 0] == 'X' && matriz[2, 1] == 'X' && matriz[2, 2] == 'X')
                res = false;
            if (matriz[0, 0] == 'X' && matriz[1, 1] == 'X' && matriz[2, 2] == 'X')
                res = false;
            if (matriz[2, 0] == 'X' && matriz[1, 1] == 'X' && matriz[0, 2] == 'X')
                res = false;

            return res;
        }

        //JUEGO 'TRES EN RAYA'//
        static void Main(string[] args)
        {

            //CREA UNA MATRIZ 3X3 DE TIPO CHAR  (Cambio del nombre de la variable 'a -> matriz')
            char[,] matriz = new char[3, 3];
            for (int f = 0; f < 3; f++)
            {
                for (int g = 0; g < 3; g++)
                {
                    matriz[f, g] = '-';
                }
            }


            //VARIABLE 'd' QUE COMPRUEBA QUE EL TURNO PASO Y VARIABLE 'e' QUE COMPRUEBA SI EL JUEGO TERMINO 
            //(Cambio de los nombres de las variables 'd -> pasaTurno' ,'e -> juegoActivo')
            bool pasaTurno = true, juegoActivo = true;

            //VARIABLE INICIADOR 
            //(Cambio del nombre de la variable)
            char figura =' ';

            //POSICIONES A INSERTAR EN LA MATRIZ 
            //(Cambio de los nombres de las variables 'b -> posX' ,'e -> juegoActivo')
            int posX,posY;

            Console.WriteLine("-=-=-=TRES EN RAYA=-=-=-");

            //MIENTRAS EL JUEGO SIGA ACTIVO
            while (juegoActivo)
            {
                //INTRODUCE LAS COORDENADAS
                if (pasaTurno)
                {
                    Console.WriteLine("===Jugador 1===");
                    Console.WriteLine("Figura: 0");
                } 
                else
                {
                    Console.WriteLine("===Jugador 2===");
                    Console.WriteLine("Figura: X");
                }
                Console.WriteLine("Posicion en X: ");
                posX = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Posicion en Y: ");
                posY = Int32.Parse(Console.ReadLine());


                //COMPRUEBA QUE LAS COORDENADAS INTRODUCIDAS NO SE PASEN DEL LIMITE
                //(Cambio estetito de '(posY <= 3 && posY >= 1 && posX <= 3 && posX >= 1)')
                if ((posX >=1 && posX <= 3) && (posY >= 1 && posY <= 3))
                {
                    //COMPRUEBA QUE LA CASILLA ESTE VACIA
                    if (matriz[posX - 1, posY - 1] == '-')
                    {
                        //SI EL PRIMER TURNO NO PASO INSERTA LA VARIABLE t EN LAS COORDENADAS DADAS
                        if (pasaTurno)
                        {
                            figura = 'O';
                            pasaTurno = false;
                        }

                        //SI EL PRIMER TURNO PASO INSERTA LA NUEVA VARIABLE t EN LAS COORDENADAS DADAS
                        else
                        {
                            figura = 'X';
                            pasaTurno = true;
                        }

                        //RECORRE LA MATRIZ Y LA IMPRIME
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                                if (i == posY - 1 && j == posX - 1)
                                    matriz[i, j] = figura;
                                Console.Write(matriz[i, j] + "  ");
                            }
                            Console.WriteLine(" ");
                        }

                        //**CONDICIONALES PARA GANAR**//
                        //(Cambio a uan nueva funcion)
                        juegoActivo = condicionGanar(matriz);

                    }
                    else
                    {
                        Console.WriteLine("Aviso: Esa casilla esta ocupada");
                    }
                }
                else
                {
                    Console.WriteLine("Aviso: Esa casilla esta fuera de rango");
                }
            }

            //(Cambio estetico)
            Console.Write("Termino el juego, el ganador es:  ");
            if (figura == 'O')
                Console.WriteLine("Jugador 1");
            else
                Console.WriteLine("Jugador 2");
            Console.ReadKey();
        }
    }
}
