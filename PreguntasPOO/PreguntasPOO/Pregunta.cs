using System;
using System.Collections.Generic;
using System.Text;

namespace PreguntasPOO
{
    interface Pregunta
    {
        void setPregunta(string pregunta);
        void setOpciones(string opciones);
        void setRespuestaU(string respuesta);
        string getRespuestaU();
        string[] getOpciones();
        string getPregunta();
        int getTipo();
        bool Comprobar();
        void Info();
    }
}
