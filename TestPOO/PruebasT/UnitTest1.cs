﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestPOO;

namespace PruebasT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPreguntaOpcionesCorrecta()
        {
            //Arrange , se inicializan las variables para la prueba            
            PreguntaOpciones po = new PreguntaOpciones(1, "¿Cuánto es 2 + 2?", "1,2,4,6", 3);
            String respuestaUsuario = "3";
            po.setRespuestaU(respuestaUsuario);
            bool expected = true;

            //Act , se usa el método que se quiere probar
            bool actual = po.Comprobar();

            //Assert , validar lo que queremos que se cumpla
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPreguntaOpcionesIncorrecta()
        {
            //Arrange , se inicializan las variables para la prueba            
            PreguntaOpciones po = new PreguntaOpciones(1, "¿En qué planeta estamos?", "Tierra,Venus,Marte,Júpiter", 1);
            String respuestaUsuario = "2";
            po.setRespuestaU(respuestaUsuario);
            bool expected = false;

            //Act , se usa el método que se quiere probar
            bool actual = po.Comprobar();

            //Assert , validar lo que queremos que se cumpla
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPreguntaAbiertaCorrecta()
        {
            //Arrange , se inicializan las variables para la prueba            
            PreguntaAbierta po = new PreguntaAbierta(2, "¿Qué significa POO?", "programación,orientada,objetos", 0);
            String respuestaUsuario = "programación orientada a objetos";
            po.setRespuestaU(respuestaUsuario);
            bool expected = true;

            //Act , se usa el método que se quiere probar
            bool actual = po.Comprobar();

            //Assert , validar lo que queremos que se cumpla
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPreguntaAbiertaIncorrecta()
        {
            //Arrange , se inicializan las variables para la prueba            
            PreguntaAbierta po = new PreguntaAbierta(2, "¿Que día es hoy?", "jueves", 0);
            String respuestaUsuario = "hoy es sabado";
            po.setRespuestaU(respuestaUsuario);
            bool expected = false;

            //Act , se usa el método que se quiere probar
            bool actual = po.Comprobar();

            //Assert , validar lo que queremos que se cumpla
            Assert.AreEqual(expected, actual);
        }
    }
}
