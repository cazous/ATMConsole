using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    internal interface IConta
    {
        int GetId();

        string GetNome();

        string GetSaldo();
        
        string addSaldo(double _saldoAdicionado);

        string removerSaldo(double _saldoRemovido);
    }
}
