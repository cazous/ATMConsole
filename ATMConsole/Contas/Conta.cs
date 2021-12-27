using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    internal class Conta : IConta
    {
        private int Id;
        private string Nome;
        private double Saldo;

        public Conta(string _nome, int _id)
        {
            this.Id = _id;
            this.Nome = _nome;
            SetSaldo(0);
        }

        public int GetId()
        {
            return Id;
        }

        public string GetNome()
        {
            return Nome;
        }

        public string GetSaldo()
        {
            return Saldo.ToString();
        }

        private void SetSaldo(double _saldo)
        {
            Saldo = _saldo;
        }

        public override string ToString()
        {
            return "ID: " + Id + " Nome: " + Nome + " Saldo: " + Saldo;
        }

        public string addSaldo(double _saldoAdicionado)
        {
            SetSaldo(Saldo + _saldoAdicionado);
            return GetSaldo();
        }   
        public string removerSaldo(double _saldoRemovido)
        {
            SetSaldo(Saldo - _saldoRemovido);
            return GetSaldo();
        }

    }
}
