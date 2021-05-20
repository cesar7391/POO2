﻿using System;
using SpreadsheetLight;
using System.Collections.Generic;
using System.Text;

namespace PreguntasPOO
{
    class LectorExcel
    {
        List<String> listaPreguntas = new List<string>();
        public List<String> LeerPreguntas(int nPreguntas)
        {            
            Console.Write("Introduzca ruta del archivo: ");
            string ruta = Console.ReadLine();
            Console.Write("Introduzca nombre del archivo: ");
            string nombre = Console.ReadLine();

            string path = @"" + ruta + "\\" + nombre + ".xlsx";
            SLDocument sl = new SLDocument(path);

            int filas = 2;
            while (!string.IsNullOrEmpty(sl.GetCellValueAsString(filas, 1))) { filas++; }

            if(nPreguntas+1 < filas)
            {
                for (int i = 2; i < nPreguntas + 2; i++)
                {
                    int tipo = sl.GetCellValueAsInt32(i, 1);
                    string pregunta = sl.GetCellValueAsString(i, 2);
                    string opciones = sl.GetCellValueAsString(i, 3);
                    string respuesta = sl.GetCellValueAsString(i, 4);

                    String todo = tipo + "|" + pregunta + "|" + opciones + "|" + respuesta;
                    listaPreguntas.Add(todo);
                    //Console.WriteLine("{0}, {1}, {2}", tipo, pregunta, respuesta);                    
                }
            } else
            {
                filas = 2;
                while (!string.IsNullOrEmpty(sl.GetCellValueAsString(filas, 1))) 
                {
                    int tipo = sl.GetCellValueAsInt32(filas, 1);
                    string pregunta = sl.GetCellValueAsString(filas, 2);
                    string opciones = sl.GetCellValueAsString(filas, 3);
                    string respuesta = sl.GetCellValueAsString(filas, 4);

                    String todo = tipo + "|" + pregunta + "|" + opciones + "|" + respuesta;
                    listaPreguntas.Add(todo);
                    filas++; 
                }
            }           

            return listaPreguntas;
        }

        public void Contenido()
        {
            for(int i = 0; i< listaPreguntas.Count; i++)
            {
                Console.WriteLine(listaPreguntas[i]);
            }
        }
    }
}