using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    internal class Lista
    {
        private List<IConta> listaConta = new List<IConta>();
        private int idConta = 0;

        #region Criação de Contas
        public Conta criarConta(string _nome)
        {

            Conta conta = new Conta(_nome, idConta);
            idConta++;
            listaConta.Add(conta);

            return conta;
        }
        public ContaEspecial CriarContaEspecial(string _nome)
        {
            ContaEspecial contaEspecial = new ContaEspecial(_nome, idConta);
            idConta++;
            listaConta.Add(contaEspecial);

            return contaEspecial;
        }
        #endregion

        #region Busca de Contas
        public void exibirContas()
        {
            listaConta.ForEach(x => Console.WriteLine(x));
        }

        public void exibirContasEspeciais()
        {
            foreach (var item in listaConta.Where(x => x.GetType() == typeof(ContaEspecial)))
            {
                Console.WriteLine(item);
            }
            //foreach (var item in listaConta)
            //{
            //    if (item.GetType() == typeof(ContaEspecial))
            //        Console.WriteLine(item);
            //}
        }

        public Conta procurarPorId(int _idConta)
        {
            return (Conta)listaConta[_idConta];
        }
        
        public ContaEspecial procurarPorIdEspecial(int _idConta)
        {
            return (ContaEspecial)listaConta[_idConta];
        }

        public Conta procurarPorNome(string _nome)
        {

            return (Conta)listaConta.First(x => x.GetNome().Equals(_nome));
        }
        #endregion

        public void deletarConta(int _id)
        {
            listaConta.RemoveAt(_id);
        }

        public bool validarIdConta(int _id)
        {
            foreach (var item in listaConta)
            {
                if (item.GetId() == _id)
                {
                    return true;
                }
            }
            return false;
        }

        public bool validarNomeConta(string _nome)
        {
            foreach (var item in listaConta)
            {
                if (item.GetNome().Equals(_nome))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
