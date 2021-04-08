using Exercicios.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace HelloWorldTest
{
    [TestClass]
    public class CachorroTest
    {
        [TestMethod]
        public void Cachorro_Latir_Test()
        {
            Cachorro leia = new Cachorro();
            string latido = leia.Latir(10);

            Console.WriteLine(latido);

            Assert.AreEqual("Au Au Au Au Au Au Au Au Au Au", latido);
        }


        //Cachorro Leia
        [TestMethod]
        public void Leia_QuantoDevoComer_Test()
        {
            Cachorro leia = new Cachorro();
            string quantoDevoComer = leia.QuantoDevoComer(1);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 1kg, devo comer 50g por dia", quantoDevoComer);

        }


        //Cachorro Tequila
        [TestMethod]
        public void Tequila_QuantoDevoComer_Test()
        {
            Cachorro tequila = new Cachorro();
            string quantoDevoComer = tequila.QuantoDevoComer(30);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 30kg, devo comer 1500g por dia", quantoDevoComer);

        }


        //Cachorro Yuri
        [TestMethod]
        public void Yuri_QuantoDevoComer_Test()
        {
            Cachorro yuri = new Cachorro();
            string quantoDevoComer = yuri.QuantoDevoComer(15);

            Console.WriteLine(quantoDevoComer);

            Assert.AreEqual("Como tenho 15kg, devo comer 750g por dia", quantoDevoComer);

        }


        //Nome do Cachorro
        [TestMethod]
        public void Cachorro_Set_Get_Nome_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetNome("Yuri");
            string nome = yuri.GetNome();

            Console.WriteLine(nome);
            Assert.AreEqual("Yuri", nome);
        }

        //Sexo do Cachorro
        [TestMethod]
        public void Cachorro_Set_Get_Sexo_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetSexo("Macho");
            string sexo = yuri.GetSexo();

            Console.WriteLine(sexo);
            Assert.AreEqual("Macho", sexo);
        }


        //Raça do Cachorro
        [TestMethod]
        public void Cachorro_Set_Get_Raca_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetRaca("Bulldod Frances");
            string raca = yuri.GetRaca();

            Console.WriteLine(raca);
            Assert.AreEqual("Bulldod Frances", raca);
        }


        //Porte do Cachorro
        [TestMethod]
        public void Cachorro_Set_Get_Porte_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPorte("Médio");
            string porte = yuri.GetPorte();

            Console.WriteLine(porte);
            Assert.AreEqual("Médio", porte);
        }


        //Idade do Cachorro
        [TestMethod]
        public void Cachorro_Set_Get_Idade_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetIdade(2);
            int idade = yuri.GetIdade();

            Console.WriteLine(idade);
            Assert.AreEqual(2, idade);
        }


        //Peso do Cachorro
        [TestMethod]
        public void Cachorro_Set_Get_Peso_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPeso(15);
            double peso = yuri.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(15, peso);
        }


        //Peso do Cachorro
        [TestMethod]
        public void Cachorro_Set_Get_Peso_Nao_Pode_Ser_Negativo_Test()
        {
            Cachorro yuri = new Cachorro();

            yuri.SetPeso(-10);
            double peso = yuri.GetPeso();

            Console.WriteLine(peso);
            Assert.AreEqual(0, peso);
        }


        [TestMethod]
        public void Cachorro_Set_Get_Vacinado_Test()
        {
            Cachorro tequila = new Cachorro();

            tequila.SetVacinado(true);
            bool vacinado = tequila.GetVacinado();

            Console.WriteLine(vacinado);
            Assert.AreEqual(true, vacinado);
        }
    }
}
