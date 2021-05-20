using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPOO
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
