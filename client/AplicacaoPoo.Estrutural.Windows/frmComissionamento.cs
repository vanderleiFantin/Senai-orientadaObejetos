using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacaoPoo.Estrutural.Windows
{

    public partial class frmComissionamento : Form
    {

        
        public frmComissionamento()
        {
            InitializeComponent();
            
            
          
        }
        
        public void btnCalcularComissao_Click(object sender, EventArgs e)
        {
            //public decimal CalcularComissao(decimal valor)
            //{
            //    var PrecoUnitario = decimal.Parse(txtCodigoPeca.Text);
            //    var QuantidadeVendida = decimal.Parse(txtQuantidadePeca.Text);
            //    var valorComissao = ((PrecoUnitario * QuantidadeVendida) * 5) / 100;
            //}

        }

       

        private void HabilitarOuDesabilitarBotaoCalcular(object sender, EventArgs e)
        {
            if (txtCodigoPeca.Text != "" && txtQuantidadePeca.Text != "")
            {
                btnCalcularComissao.Enabled = true;
            }
        }

        
    }
}
