﻿using AplicacaoPoo.Windows.Helpers;
using AplicacaoPoo.Windows.services;
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
    public partial class frmConversorMoeda : Form
    {
       
        public frmConversorMoeda()
        {
            InitializeComponent();
            
            lblPrimeiroValor.Text = $"1 {MoedaHelper.Dolar} igual a ";
            lblSegundoValor.Text = $"5,12{MoedaHelper.Real}";
        }

       
        private void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                if (txtValorEmDolar.Text == "") return;
  
                              
                var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
                var Moeda = new ConverterMoedaService();
                var resultado = Moeda.ConverterDolarEmReal(valorEmDolar);
                lblPrimeiroValor.Text = $"{valorEmDolar}{MoedaHelper.Dolar} igual a ";
                lblSegundoValor.Text = $"{resultado}{MoedaHelper.Real}";

            }
            catch (Exception)
            {
                MessageBox.Show("A cotação do dólar é um valor decimal");
                txtValorEmDolar.Focus();
                
            }

        }

        private void cmbPrimeiroValor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
