using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        public string Latir()
        {
            return "Au Au";
        }

        public string QuantoDevoComer(int pesoKg)
        {
            //MANEIRA 1 DE RESOLVER
            //double qntdRacaoGramas = pesoKg * 50;
            //string msg = "Como tenho " + pesoKg + "kg, devo comer " + qntdRacaoGramas + "g por dia"; //concatenação "simples"
            //string msg = $"Como tenho {pesoKg}kg, devo comer {qntdRacaoGramas}g por dia"; //concatenação "interpolação"
            //return msg;

            //MANEIRA 2 DE RESOLVER
           return $"Como tenho {pesoKg}kg, devo comer {pesoKg * 50}g por dia";
        }
    }
}
