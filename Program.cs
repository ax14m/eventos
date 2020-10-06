using System;

namespace eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deportes");
            Console.WriteLine("categoria");
            string categoria = Console.ReadLine();
             Console.WriteLine("nombre equipo");
            string nequipo = Console.ReadLine();
             Console.WriteLine("cantidad jugadores");
            short cjugadores = short.Parse(Console.ReadLine());
            Console.WriteLine("nombre");
            string ndeporte = Console.ReadLine();

             var deporteuno = new Dpelota ()
            
            {

                categoria = categoria,
                nequipo = nequipo,
                Cjugadores=cjugadores,
                nombreDepor = "Futbol",

            };

            Console.WriteLine($"Deporte con categoria: {deporteuno.categoria} y Nombre del deporte: {deporteuno.nombreDepor}");
        }

        
    
    }
}
