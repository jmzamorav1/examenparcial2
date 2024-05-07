using System;


namespace parcial
{
    class Program


    {
        static void Main()

        {


            int[] nota = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Ingrese la nota del alumno numero {i + 1}: ");
                nota[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros ingresados del alumno:");
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine($"{i + 1}: {nota[i]}");
            }

            int suma = 0;
            foreach (int num in nota)
            {
                suma += num;
            }
            Console.WriteLine($"\nSuma de los números: {suma}");


            double promedio = (double)suma / nota.Length;
            Console.WriteLine($"Promedio de los números: {promedio}");

            Console.ReadKey();

        }
        public void 
            
            


        





    }





}