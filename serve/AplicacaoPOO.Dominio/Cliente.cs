using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPOO.Dominio
{
    //Criar um novo formulario frmCliente
    //Adicionar 4 textbox e 4 label para
    //Nome, CPF, Valor de debito, Valor de credito
    public class Cliente
    {
        public string Nome { get; set; }
        public double SaldoInicial { get; set; }
        public string Cpf { get; set; }
        public Debito debito { get; set; }
        public Credito credito { get; set; }
    }
}
