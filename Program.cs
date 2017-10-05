using System;

namespace codicioso
{
    class Program
    {
        static void Main(string[] args)
        {

            float cambioQueseDebe,cam5,cam001,cam01,cam05,cam1;

            do
            {
                System.Console.WriteLine("Cuánto cambio se te debe: ");
                float.TryParse(Console.ReadLine(), out cambioQueseDebe);
            } while( cambioQueseDebe <= 0 );
            cam5=cambioQueseDebe/5;
            cambioQueseDebe=cambioQueseDebe%5;
            cam1=cambioQueseDebe/1;
            cambioQueseDebe=cambioQueseDebe%1;
            cam05=cambioQueseDebe/0.5f;
            cambioQueseDebe=cambioQueseDebe%0.5f; 
            cam01=cambioQueseDebe/0.1f;
            cambioQueseDebe=cambioQueseDebe%0.1f;
            cam001=cambioQueseDebe/0.001f;
            cambioQueseDebe=cambioQueseDebe%0.001f;
            Decimal cam5v = Decimal.Parse(string.Format("{0:N0}", cam5));
            Decimal cam1v = Decimal.Parse(string.Format("{0:N0}", cam1));
            Decimal cam05v = Decimal.Parse(string.Format("{0:N0}", cam05));
            Decimal cam01v = Decimal.Parse(string.Format("{0:N0}", cam01));
            Decimal cam001v= Decimal.Parse(string.Format("{0:N0}", cam001));
            System.Console.WriteLine("Tu cambio vuelto es:");
            System.Console.WriteLine($"monedas de 5: {cam5v}");
            System.Console.WriteLine($"monedas de 1: {cam1v}");
            System.Console.WriteLine($"monedas de 0.5: {cam05v}");
            System.Console.WriteLine($"monedas de 0.1: {cam01v}");
            System.Console.WriteLine($"monedas de 0.001:{cam001v}");


        }
    }
}
