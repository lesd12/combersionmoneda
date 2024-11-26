// See https://aka.ms/new-console-template for more informatio

namespace ConversionMoneda
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos las moneda 
            const decimal cambioDolar = 4000M;
            const decimal cambioEuro = 4500M;


            while (true)
            {
                //campo de entrada 
                Console.WriteLine("Ingrese un valo en pesos colombianos(COP):");

                //lee el dato que ingreso el usuario y lo convierte en un numero decimal
                if (decimal.TryParse(Console.ReadLine(), out decimal pesosCOP))
                {
                    //relizacion de conversion de peso colombiano a dolar o euro 
                    decimal valorEnDolar = pesosCOP / cambioDolar;
                    decimal valorEnEuro = pesosCOP / cambioEuro;

                    //muestra los resultados de la consersion 
                    Console.WriteLine($"\n{pesosCOP} pesos colombianos equivalen a:");
                    Console.WriteLine($"{valorEnDolar:F2} dolares");
                    Console.WriteLine($"{valorEnEuro:F2} Euros");
                    break;
                }
                else
                {
                    //se muestra este error si no se ingreso un campo valido 
                    Console.WriteLine("por favor ingrese un numero valido.");
                }
            }
        }
    }
}

        
        
                

