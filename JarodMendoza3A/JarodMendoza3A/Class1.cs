using System;
using System.Collections.Generic;
using System.Text;

namespace JarodMendoza3A
{
    class Class1
    {
        public void menu()
        {
            Console.WriteLine("========== MENÚ PRINCIPAL ==========");
            Console.WriteLine(" 0) Salir.");
            Console.WriteLine(" 1) Ejercicio 1. ");
            Console.WriteLine(" 2) Ejercicio 2.");
            Console.WriteLine(" 3) Ejercicio 3.");
            Console.WriteLine(" 4) Ejercicio 4.");
            Console.WriteLine(" 5) Ejercicio 5.");
            Console.WriteLine(" 6) Ejercicio 6.");
            Console.WriteLine(" 7) Ejercicio 7.");
            Console.WriteLine(" 8) Ejercicio 8.");
            Console.WriteLine(" 9) Ejercicio 9.");
            Console.WriteLine("10) Ejercicio 10.");
            Console.WriteLine("====================================");
        }
        public void mayormenor()
        {
            Console.WriteLine("Ingrese la cantidad de números a leer");
            int cantnumeros = int.Parse(Console.ReadLine());
            int mayor = 0, menor = 0;


            for (int i = 0; i < cantnumeros; i++)
            {
                Console.WriteLine("Digite un número");
                int Num = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    mayor = Num;
                    menor = Num;
                }
                if (Num > mayor)
                {
                    mayor = Num;
                }
                if (Num < menor)
                {
                    menor = Num;
                }
                Num = 0;
            }
            Console.WriteLine("El número mayor es:" + mayor);
            Console.WriteLine("El número menor es:" + menor);
            new Class1().menu();
        }
        public void cuadradodeasteriscos()
        {
            Console.WriteLine("Ingrese el tamaño del cuadrado");
            string numero = Console.ReadLine();
            bool error = Int16.TryParse(numero, out short tamaño);

            if (error)
            {
                for (int j = 1; j <= tamaño; j++)
                {
                    Console.Write("*  ");
                }
                Console.WriteLine();

                for (int j = 1; j <= tamaño; j++)
                {
                    Console.Write("*");
                    for (int i = 1; i <= tamaño - 2; i++)
                    {
                        Console.Write("   ");
                    }
                    Console.WriteLine("  *  ");
                }
                for (int j = 1; j <= tamaño; j++)
                {
                    Console.Write("*  ");
                }
            }



            new Class1().menu();
        }
        public void calcularprecio()
        {
            int controlador = 1;
            int cantidad = 1;
            float precio = 1;
            float total;
            float sumatotal = 0;
            while (controlador != 0)
            {



                if (cantidad == 0 || precio == 0)
                {
                    Console.WriteLine("Valor a pagar: " + sumatotal);
                    controlador = 0;
                    new Class1().menu();

                }
                else
                {
                    Console.WriteLine("Introduzca la cantidad vendida: ");
                    cantidad = int.Parse(Console.ReadLine());
                    while (cantidad<0)
                    {
                        Console.WriteLine("Valor no permitido, intruduzca una cantidad positiva: ");
                        cantidad = int.Parse(Console.ReadLine());
                    }
                   
                }




                if (cantidad == 0 || precio == 0)
                {


                }
                else
                {
                    Console.WriteLine("Introduzca el precio: ");
                    precio = float.Parse(Console.ReadLine());
                    while (precio < 0)
                    {
                        Console.WriteLine("Valor no permitido, intruduzca un precio positivo: ");
                        precio = int.Parse(Console.ReadLine());
                    }
                }

                total = cantidad * precio;
                sumatotal = sumatotal + total;


            }

        }
        public void calcularsueldo()
        {
            int valorhora = 15;
            int sueldo = 0;
            string pregunta = "si";
            while (pregunta == "si")
            {


                Console.WriteLine("Ingrese cantidad de horas semanales: ");
                int cantidahora = int.Parse(Console.ReadLine());
                if (cantidahora < 35)
                {
                    sueldo = valorhora * cantidahora;
                }
                else
                {
                    sueldo = valorhora * 35;
                    valorhora = 22;
                    cantidahora = cantidahora - 35;
                    int horasextra = valorhora * cantidahora;
                    sueldo = sueldo + horasextra;
                }
                Console.WriteLine("sueldo semanal es de: " + sueldo);
                Console.WriteLine("¿Quíere consultar otro salario?   responda: si/no ");
                pregunta = Console.ReadLine();
            }
            new Class1().menu();
        }


        public void piramide()
        {

            Console.WriteLine("Ingrese niveles de la piramide");
            int niveles = int.Parse(Console.ReadLine());
            if (niveles != 0)
            {
                int total;
                int aumento;
                for (int i = 1; i <= niveles; i++)
                {
                    aumento = niveles - i;
                    total = i + (i - 1);
                    for (int i1 = 0; i1 < aumento; i1++)
                    {
                        Console.Write(" ");
                    }
                    for (int i2 = 0; i2 < total; i2++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");

                }
            }
            new Class1().menu();
        }

        public void rombo()
        {

            Console.WriteLine("Ingrese niveles de la piramide");
            int niveles = int.Parse(Console.ReadLine());
            if (niveles != 0)
            {
                int total;
                int aumento;
                for (int i = 1; i <= niveles; i++)
                {
                    aumento = niveles - i;
                    total = i + (i - 1);
                    for (int i1 = 0; i1 < aumento; i1++)
                    {
                        Console.Write(" ");
                    }
                    for (int i2 = 0; i2 < total; i2++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }

                for (int i = niveles; i >= 1; i--)
                {
                    aumento = niveles - i;
                    total = i + (i - 1);
                    for (int i1 = aumento; i1 > 0; i1--)
                    {
                        Console.Write(" ");
                    }
                    for (int i2 = total; i2 > 0; i2--)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine(" ");
                }
            }
            new Class1().menu();
        }

        public void columnas()
        {
            Console.WriteLine("_____________________________________________");
            int resta;
            for (int i = 1; i < 101; i++)
            {
                resta = 100 - i;
                if (i >= 1 && i <= 9)
                {
                    Console.Write("|  " + i);
                    Console.WriteLine("            ||            " + resta + "  |");
                }
                else
                {
                    if (i >= 10 && i <= 90)
                    {
                        Console.Write("|  " + i);
                        Console.WriteLine("           ||            " + resta + "  |");
                    }
                    else
                    {
                        if (i >= 91 && i <= 99)
                        {
                            Console.Write("|  " + i);
                            Console.WriteLine("           ||            " + resta + "   |");
                        }
                        else
                        {
                            if (i == 100)
                            {
                                Console.Write("|  " + i);
                                Console.WriteLine("          ||            " + resta + "   |");
                            }
                        }
                    }
                }

            }
            Console.WriteLine("|_________________________________|");
            new Class1().menu();

        }

        public void columna3()
        {

            Console.WriteLine("Ingrese un número");
            int num;
            num = int.Parse(Console.ReadLine());
            while (num < 0)
            {
                Console.WriteLine("Ingrese un número positivo");
                num = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= num; i++)
            {
                Console.Write(i);
                if (i <= num / 2)
                {
                    Console.Write("      " + (i + i));

                }
                else
                {
                    Console.Write(" ");
                }
                if (i <= num / 3)
                {
                    Console.WriteLine("      " + (i + i + i));

                }
                else
                {
                    Console.WriteLine(" ");
                }

            }



            new Class1().menu();
        }

        public void tablamultiplicar() {

            for (int i = 1; i <= 15; i++)
            {
                for (int j = 1; j <=12; j++)
                {
                    Console.WriteLine("{0} x {1} = {2}",+i,+j,+(i * j));
                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");

            }
        }

        public void menuaux()
        {
            Console.WriteLine("========== MENÚ AUXILIAR ==========");
            Console.WriteLine(" 1) Salir 1. ");
            Console.WriteLine(" 2) Sumatoria 2.");
            Console.WriteLine(" 3) Factorial 3.");
            Console.WriteLine("====================================");
            

        }
        public void sumatorio()
        {
            Console.WriteLine("Ingrese un número");
            int numero = int.Parse(Console.ReadLine());
            int sumatorianumero = 0;
            for (int i = 1; i <= numero; i++)
            {
                sumatorianumero = sumatorianumero + i;
            }
            Console.WriteLine("sumatoria del número {0} es: {1}", numero, sumatorianumero);
            new Class1().menuaux();

        }
        public void factorial()
        {
            Console.WriteLine("Ingrese un número");
            int numero = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("factorial del número {0} es: {1}", numero, factorial);
            new Class1().menuaux();

        }
        static void Main(string[] args)
        {
            new Class1().menu();
            int op = int.Parse(Console.ReadLine());
            while (op!=0)
                
            {


                
              
                switch (op)
                {
                    case 0:
                 
                        break;
                    case 1:
                        new Class1().mayormenor();
                        op = int.Parse(Console.ReadLine());
                        break;

                    case 2:
                        new Class1().cuadradodeasteriscos();
                        op = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        new Class1().calcularprecio();
                        op = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        new Class1().calcularsueldo();
                        op = int.Parse(Console.ReadLine());
                        break;
                    case 5:
                        new Class1().piramide();
                        op = int.Parse(Console.ReadLine());
                        break;
                    case 6:
                        new Class1().rombo();
                        op = int.Parse(Console.ReadLine());
                        break;
                    case 7:
                        new Class1().columnas();
                        op = int.Parse(Console.ReadLine());
                        break;
                    case 8:
                        new Class1().columna3();
                        op = int.Parse(Console.ReadLine());
                        break;
                    case 9:
                        new Class1().tablamultiplicar();
                        op = int.Parse(Console.ReadLine());
                        break;
                    case 10:
                        new Class1().menuaux();
                        int op2 = int.Parse(Console.ReadLine());
                        while (op2 != 1)

                        {




                            switch (op2)
                            {

                                case 1:
                                    new Class1().menu();
                                    return;



                                case 2:
                                    new Class1().sumatorio();
                                    op2 = int.Parse(Console.ReadLine());
                                    break;
                                case 3:
                                    new Class1().factorial();
                                    op2 = int.Parse(Console.ReadLine());
                                    break;
                                default:
                                    Console.WriteLine("Valor no permitido en el menú, vuelva a escoger una opción");
                                    op2 = int.Parse(Console.ReadLine());
                                    break;
                            }

                        }
                        new Class1().menu();

                        op = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Valor no permitido en el menú, vuelva a escoger una opción");
                         op = int.Parse(Console.ReadLine());
                        break;
                }
                
            }
            
           

        }
}
}
