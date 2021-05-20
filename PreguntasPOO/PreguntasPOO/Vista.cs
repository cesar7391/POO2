using System;

namespace PreguntasPOO
{
    class Vista
    {
        static Test prueba = new Test();
        static void Main(string[] args)
        {            
            prueba.ObtenerPreguntas();
            Console.WriteLine("INICIANDO PRUEBA");
            prueba.IniciarTest();            
            prueba.Calificar();
        }
    }
}
