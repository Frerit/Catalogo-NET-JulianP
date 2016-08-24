using System;
using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora_Test
{
    [TestClass]
    public class Calculadora_Pruebas
    {
        [TestMethod]
        public void Validar_que_si_genere_negativos()
        {
            Procedimientos Restas = new Procedimientos();
            int Numero1 = 3;
            int Numero2 = 4;

            int result = Restas.Restar(Numero1, Numero2);
            int Esperado = -1;
            Assert.AreEqual(Esperado, result);

            //TDD
        }
        [TestMethod]
        public void Validar_que_si_valor_eviado_cero()
            // Debe validar si el segundo numero es mayor al primero retorne 0
        {
            Procedimientos Restas = new Procedimientos();
            int Numero1 = 3;
            int Numero2 = 0;

            int result = Restas.Restar(Numero1, Numero2);
            int Esperado = 3;
            Assert.AreEqual(Esperado,result);
        }
        [TestMethod]
        public void Validar_que_genere_error_si_es_menosuno()
            
        {
            Procedimientos Multiplicaciones = new Procedimientos();
            int Numero1 = 3;
            int Numero2 = 4;

            int result = Multiplicaciones.Multiplicar(Numero1, Numero2);
            int Esperado = -1;

            Assert.AreEqual(Esperado , result);
        }
        [TestMethod]
        public void Validar_que_genere_error_si_es_cero()

        {
            Procedimientos Multiplicaciones = new Procedimientos();
            int Numero1 = 3;
            int Numero2 = 0;

            int result = Multiplicaciones.Multiplicar(Numero1, Numero2);
            int Esperado = 0;

            Assert.AreEqual(Esperado, result);
        }

        // Si el Segundo numeo es par retorne menos 1
    }
}
