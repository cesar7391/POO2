using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPOO
{
    public interface Pregunta
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
