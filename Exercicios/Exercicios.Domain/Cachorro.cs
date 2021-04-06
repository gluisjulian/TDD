using System;

namespace Exercicios.Domain
{
    public class Cachorro
    {
        #region Nome
        private string _nome;
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }
        #endregion Nome


        #region Sexo
        private string _sexo;
        public void SetSexo(string sexo)
        {
            _sexo = sexo;
        }

        public string GetSexo()
        {
            return _sexo;
        }
        #endregion Sexo


        #region Raca
        private string _raca;
        public void SetRaca(string raca)
        {
            _raca = raca;
        }

        public string GetRaca()
        {
            return _raca;
        }
        #endregion Raca


        #region Porte
        private string _porte;
        public void SetPorte(string porte)
        {
            _porte = porte;
        }

        public string GetPorte()
        {
            return _porte;
        }
        #endregion Porte


        #region Idade
        private int _idade;
        public void SetIdade(int idade)
        {
            _idade = idade;
        }

        public int GetIdade()
        {
            return _idade;
        }
        #endregion Idade


        #region Peso
        private double _peso;
        public void SetPeso(double peso)
        {
            if(peso < 0)
            {
                _peso = 0;
            }
            else 
            {
                _peso = peso;
            }
            
        }

        public double GetPeso()
        {
            return _peso;
        }
        #endregion Peso



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
