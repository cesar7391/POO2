using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPOO
{
    public class PreguntaOpciones : Pregunta
    {
        private String pregunta;
        private String opciones;
        private int respuestaOK;
        private string respuestaU;
        private int tipo;

        public int getTipo()
        {
            return tipo;
        }

        public PreguntaOpciones(int tipo, string pregunta, string opciones, int respuestaOK)
        {
            this.pregunta = pregunta;
            this.opciones = opciones;
            this.respuestaOK = respuestaOK;
            this.tipo = tipo;
        }
        public void setPregunta(string pregunta) { this.pregunta = pregunta; }
        public void setOpciones(string opciones) { this.opciones = opciones; }
        public void setRespuestaU(string respuestaU) { this.respuestaU = respuestaU; }
        public string getRespuestaU() { return respuestaU; }

        public string getPregunta() { return pregunta; }

        public string[] getOpciones()
        {
            string[] opcionesA = opciones.Split(',');
            return opcionesA;
        }

        public bool Comprobar()
        {
            int rUser = Convert.ToInt32(respuestaU);
            if (rUser == respuestaOK)
                return true;
            else
                return false;
        }

        public void Info()
        {
            Console.WriteLine("Pregunta Opciones: {0}, Opciones: {1}, Respuesta: {2}", pregunta, opciones, respuestaOK);
        }
    }
}
