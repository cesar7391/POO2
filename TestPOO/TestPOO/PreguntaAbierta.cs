using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPOO
{
    public class PreguntaAbierta : Pregunta
    {
        private String pregunta;
        private String opciones;
        private int respuestaOK;
        private string respuestaU;
        private int tipo;

        public int Tipo { get => tipo; set => tipo = value; }

        public PreguntaAbierta(int tipo, string pregunta, string opciones, int respuestaOK)
        {
            this.pregunta = pregunta;
            this.opciones = opciones;
            this.tipo = tipo;
            this.respuestaOK = respuestaOK;

        }

        public int getTipo()
        {
            return tipo;
        }

        public void setPregunta(string pregunta) { this.pregunta = pregunta; }
        public void setRespuestaU(string respuestaU) { this.respuestaU = respuestaU; }
        public void setOpciones(string opciones) { this.opciones = opciones; }
        public string getRespuestaU() { return respuestaU; }


        public string getPregunta()
        {
            return pregunta;
        }

        public string[] getOpciones()
        {
            string[] opcionesA = opciones.Split(',');
            return opcionesA;
        }

        public bool Comprobar()
        {
            List<string> pClave = new List<String>();
            for (int i = 0; i < getOpciones().Length; i++)
            {
                pClave.Add(getOpciones()[i]);
            }
            //respuestaU.Replace(" ", string.Empty);
            string[] respuestasU = respuestaU.Split(' ');

            for (int i = 0; i < respuestasU.Length; i++)
            {
                if (pClave.Contains(respuestasU[i]))
                    pClave.Remove(respuestasU[i]);
            }

            if (pClave.Count == 0)
                return true;
            else
                return false;
        }

        public void Info()
        {
            Console.WriteLine("Pregunta Abierta: {0}, Opciones: {1}", pregunta, opciones);
        }
    }
}
