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
    }
}
