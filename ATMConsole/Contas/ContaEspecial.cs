using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    internal class ContaEspecial : IConta
    {
        private int Id;
        private string Nome;
        private double Saldo;
        private double CreditoEspecial;

        public ContaEspecial(string _nome, int _id)
        {
            this.Nome = _nome;
            this.Id = _id;
            SetSaldo(0);
            SetCreditoEspecial(1000);
        }
     
        public double GetCreditoEspecial()
        {
            return CreditoEspecial;
        }
        private void SetCreditoEspecial(double _saldoCredito)
        {
            CreditoEspecial = _saldoCredito;
        }

        public double addCreditoEspecial(double _creditoAdicionado)
        {
            SetCreditoEspecial(GetCreditoEspecial() + _creditoAdicionado);
            return GetCreditoEspecial();
        }

        public double removerCreditoEspecial(double _creditoRemovido)
        {
            SetCreditoEspecial(GetCreditoEspecial() + _creditoRemovido);
            return GetCreditoEspecial();
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
            return Saldo + "Crédito Especial: " + GetCreditoEspecial();
        }

        public void SetSaldo(double _saldo)
        {
            Saldo = _saldo;
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

        public override string ToString()
        {
            return "ID: " + Id + " Nome: " + Nome + " Saldo: " + Saldo + " Crédito Especial: " + CreditoEspecial;
        }
    }
}
