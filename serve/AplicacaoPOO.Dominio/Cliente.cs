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
        string Nome { get; set; }
        string Cpf { get; set; }
        Debito debito { get; set; }
        Credito credito { get; set; }
    }
}
