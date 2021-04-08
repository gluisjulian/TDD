using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Exercicios.Domain;

namespace HelloWorldTest
{
    [TestClass]
    public class HelloWorldTest
    {
        [TestMethod]
        public void SayHello_Test()
        {
            string msg =  HelloWorld.SayHello(); //Executa Metodo SayHello pegando o retorno e colocando na variavel string msg
            Assert.AreEqual("Hello World !!!", msg); // Valida Se Hello World !!! == msg

            Console.WriteLine(msg);
        }

        [TestMethod]
        public void Tipos_PrimitivosComplexos_Test()
        {
            //Tipos Primitivos
            string msg = "Hello World";
            double peso = 1.2;
            int idade = 4;

            Console.WriteLine(msg);
            Console.WriteLine(peso);
            Console.WriteLine(idade);


            //Tipo Complexo
            Cachorro leia = new Cachorro();
            Console.WriteLine(leia);
        }

        [TestMethod]
        public void Conversao_Implicita_Test()
        {
            int inteiro = 1;
            double valor = inteiro;

            Console.WriteLine(valor);
            Assert.AreEqual(inteiro, valor);
        }

        [TestMethod]
        public void Conversao_Explicita_Test()
        {
            double valor = 3.14;
            int inteiro = (int)valor; // Conversao em CAST
            

            Console.WriteLine(inteiro);
            Assert.AreNotEqual(valor, inteiro);
        }

        [TestMethod]
        public void TipoValor_Test()
        {
            int valor = 10;
            HelloWorld.PassaValor(valor);

            Console.WriteLine(valor);
            Assert.AreEqual(10, valor);
        }


        [TestMethod]
        public void TipoReferencia_Test()
        {
            Cachorro cachorro = new Cachorro();
            cachorro.SetNome("Léia");

            HelloWorld.PassaReferencia(cachorro);
            string nomeCachorro = cachorro.GetNome();
            Console.WriteLine(nomeCachorro);
            Assert.AreEqual("Tequila", nomeCachorro);
        }

        [TestMethod]
        public void IgualdadeEntreTiposValor_Test()
        {
            int valor1 = 10;
            int valor2 = 10;

            Assert.AreEqual(valor1, valor2);
        }


        [TestMethod]
        public void DesigualdadeEntreTiposReferencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("Tequila");

            Cachorro cachorro2 = new Cachorro();
            cachorro2.SetNome("Tequila");


            Assert.AreNotEqual(cachorro1, cachorro2);
        }


        [TestMethod]
        public void IgualdadeEntreTiposReferencia_Test()
        {
            Cachorro cachorro1 = new Cachorro();
            cachorro1.SetNome("Poodle");


            Cachorro cachorro2 = cachorro1;


            Assert.AreEqual(cachorro1, cachorro2);
        }
    }
}
