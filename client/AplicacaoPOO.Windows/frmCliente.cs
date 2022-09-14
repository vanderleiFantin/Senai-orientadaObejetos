using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPOO.Windows
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
            var cliente = new Cliente();
            cliente.txtNome = "Vanderlei Farreira";
            txtNome.Text = cliente.txtNome;
            txtCPF.Text = "137.457.124-01";
            lblSaldoInicialValor.Text = "1000";

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var credito = new Credito();
            //credito.CreditarValor
        }
    }
}
