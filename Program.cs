using System;

namespace codicioso
{
    class Program
    {
        static void Main(string[] args)
        {

            float cambioQueseDebe;

            do
            {
                System.Console.Write("Cuánto cambio se te debe: ");
                float.TryParse(Console.ReadLine(), out cambioQueseDebe);
            } while( cambioQueseDebe <= 0 );
            
            System.Console.WriteLine($"Número de monedas a devolver: {numeroDeMonedas(cambioQueseDebe)}");


        }

        static int numeroDeMonedas(float seDebeCambio)
        {
            //float monedaDeCinco = 5.0f;
            //float monedaDePeso = 1.0f;
            //float monedaDeCincuetaCentavos = 0.5f;
            //float mondedaDeDiezCentavos = 0.1f;
            //float monedaDeUnCentavo = 0.01f;
            return 0;
        }
    }
}
