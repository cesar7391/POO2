using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPOO
{
    class Test
    {
        List<Pregunta> listaP = new List<Pregunta>();

        String[] valores;
        public void ObtenerPreguntas()
        {
            LectorExcel lector = new LectorExcel();
            string nPreguntas;
            int numP;

            //Se piden cuantas preguntas
            do
            {
                Console.Write("Número de preguntas: ");
                nPreguntas = Console.ReadLine();

                if (Int32.TryParse(nPreguntas, out numP))
                {
                    numP = Convert.ToInt32(nPreguntas);

                    List<String> preguntas = lector.LeerPreguntas(numP);

                    for (int i = 0; i < preguntas.Count; i++)
                    {
                        valores = preguntas[i].Split('|');

                        if (String.Equals(valores[0], "1"))
                        {
                            Pregunta pO = new PreguntaOpciones(1, valores[1], valores[2], Convert.ToInt32(valores[3]));
                            listaP.Add(pO);
                        }
                        else
                        {
                            Pregunta pA = new PreguntaAbierta(2, valores[1], valores[2], Convert.ToInt32(valores[3]));
                            listaP.Add(pA);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("EL VALOR INGRESADO NO ES VÁLIDO");
                }
            } while (Convert.ToInt32(nPreguntas) < 0);
        }


        public void IniciarTest()
        {
            for (int i = 0; i < listaP.Count; i++)
            {
                if (listaP[i].getTipo() == 1) //PREGUNTA OPCIONES
                {
                    Console.WriteLine((i + 1) + ". " + listaP[i].getPregunta());
                    string[] opciones = listaP[i].getOpciones();
                    for (int j = 0; j < opciones.Length; j++)
                    {
                        Console.WriteLine((j + 1) + ". " + opciones[j]);
                    }
                    Console.Write("SELECCIONA UNA OPCIÓN: ");
                    string respuestaU = Console.ReadLine();
                    if (Int32.TryParse(respuestaU, out int x))
                        listaP[i].setRespuestaU(respuestaU);
                    else
                        Console.WriteLine("El valor ingresado no es un número");
                }
                else //PREGUNTA ABIERTA
                {
                    Console.Write((i + 1) + ". " + listaP[i].getPregunta() + ": ");
                    String respuestaU = Console.ReadLine();
                    listaP[i].setRespuestaU(respuestaU);
                }
                Console.WriteLine("================");
            }
        }

        public void Calificar()
        {
            int contador = 0;
            Console.WriteLine("\n================");
            for (int i = 0; i < listaP.Count; i++)
            {
                //Console.WriteLine(listaP[i].getRespuestaU());
                if (listaP[i].Comprobar())
                {
                    Console.WriteLine((i + 1) + ". RESPUESTA CORRECTA");
                    contador++;
                }
                else
                {
                    Console.WriteLine((i + 1) + ". RESPUESTA INCORRECTA");
                }
            }
            Console.WriteLine("================");
            Console.WriteLine("TOTAL DE ACIERTOS: {0}/{1}", contador, listaP.Count);

        }
    }
}
