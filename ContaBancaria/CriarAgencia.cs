using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class CriarAgencia
    {
        public int IDAgencia { get; set; }
        public string Gerente { get; set; }
        public int TelAgencia { get; set; }


        public CriarAgencia(int idAgencia, string gerente, int telAgencia)
        {
            IDAgencia = idAgencia;
            Gerente = gerente;
            TelAgencia = telAgencia;

        }

        public string DadosAgencia()
        {
            return $"Agencia número: {IDAgencia}, Telefone: {TelAgencia}";
        }

    }
}
