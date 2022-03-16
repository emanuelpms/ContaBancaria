using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBancaria
{
    class Cliente
    {
        private string _nome, _cpf;
        private int  _agencia, _conta;
        private DateTime _dataCriacao, _dataNascimento;

        public void CriarCadastroCliente(string nome, string cpf, DateTime dataNacimento, CriarAgencia agencia)
        {
            this._nome = nome;
            this._cpf = cpf;
            this._dataNascimento = dataNacimento;

            var conta = new Random().Next(0, 1570);
            this._conta = conta;
            this._agencia = AgenciaCadastrada(agencia);

            _dataCriacao = DateTime.Now;
            Console.WriteLine(ContaFoiCriada());

        }

        int AgenciaCadastrada(CriarAgencia a)
        {
            return a.IDAgencia;
        }

        
        string ContaFoiCriada()
        {
            return $"sua conta foi criada, \n Agência: {_agencia} \n Conta: {_conta} \n Criada as: {_dataCriacao}";
        } 


        public string CadastroCliente()
        {
            return $"{_nome} \n {_cpf} \n Agência: {_agencia} \n Conta: {_conta} \n Criada as: {_dataCriacao} ";
        }
    }
}
