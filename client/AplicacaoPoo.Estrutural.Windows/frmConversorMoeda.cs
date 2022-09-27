using AplicacaoPoo.Windows.Helpers;
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

            lblPrimeiroValor.Text = $" 1 {MoedaHelper.Dolar} igual a ";
            lblSegundoValor.Text = $" 5,25{MoedaHelper.Real}";
            var list = new List<string>();
            var list1 = new List<string>();
            list.Add(MoedaHelper.Dolar);
            list.Add(MoedaHelper.Libra);
            list.Add(MoedaHelper.Euro);
            list.Add(MoedaHelper.Real);
            list1.Add(MoedaHelper.Dolar);
            list1.Add(MoedaHelper.Libra);
            list1.Add(MoedaHelper.Euro);
            list1.Add(MoedaHelper.Real);

            cmbPrimeiroValor.DataSource = list;
            cmbPrimeiroValor.SelectedIndex = 0;
            cmbSegundoValor.DataSource = list1;
            cmbSegundoValor.SelectedIndex = 3;
        }
        #region
        //public void txtValorEmDolar_TextChanged(object sender, EventArgs e)
        //{

        //  try
        // {
        //    if (txtValorEmDolar.Text == "") return;


        // }
        // catch (Exception)
        // {
        //     MessageBox.Show("A cotação é um valor decimal");
        //     txtValorEmDolar.Focus();

        // }


        //}
        
        //public void cmbPrimeiroValor_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    #region
        //    if (cmbPrimeiroValor.SelectedIndex == 0 && cmbSegundoValor.SelectedIndex == 3)
        //    {
        //        var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
        //        var Moeda = new ConverterMoedaService();
        //        var resultado = Moeda.ConverterDolarEmReal(valorEmDolar);
        //        lblPrimeiroValor.Text = $"{valorEmDolar}{MoedaHelper.Dolar} igual a ";
        //        lblSegundoValor.Text = $"{resultado}{MoedaHelper.Real}";
        //    }
        //    if (cmbPrimeiroValor.SelectedIndex == 2 && cmbSegundoValor.SelectedIndex==3)
        //    {
        //        var valorEmEuro = decimal.Parse(txtValorEmDolar.Text);
        //        var Moeda = new ConverterMoedaService();
        //        var resultado = Moeda.ConverterEuroEmReal(valorEmEuro);
        //        lblPrimeiroValor.Text = $"{valorEmEuro}{MoedaHelper.Euro} igual a ";
        //        lblSegundoValor.Text = $"{resultado}{MoedaHelper.Real}";
        //    }
        //    if (cmbPrimeiroValor.SelectedIndex == 1 && cmbSegundoValor.SelectedIndex == 3)
        //    {
        //        var valorEmLibra = decimal.Parse(txtValorEmDolar.Text);
        //        var Moeda = new ConverterMoedaService();
        //        var resultado = Moeda.ConverterLibraEmReal(valorEmLibra);
        //        lblPrimeiroValor.Text = $"{valorEmLibra}{MoedaHelper.Libra} igual a ";
        //        lblSegundoValor.Text = $"{resultado}{MoedaHelper.Real}";
        //    }
        //    if (cmbPrimeiroValor.SelectedIndex == 3 && cmbSegundoValor.SelectedIndex == 3)
        //    {
        //        var valorEmReal = decimal.Parse(txtValorEmDolar.Text);
        //        var Moeda = new ConverterMoedaService();
        //        var resultado = Moeda.ConverterRealEmReal(valorEmReal);
        //        lblPrimeiroValor.Text = $"{valorEmReal}{MoedaHelper.Real} igual a ";
        //        lblSegundoValor.Text = $"{resultado}{MoedaHelper.Real}";
        //    }
        //    else { return; }

            #endregion
        public void cmbPrimeiroValor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtValorEmDolar.Text == "") return;
            var valorEmDolar = decimal.Parse(txtValorEmDolar.Text);
            var moedaservice = new ConverterMoedaService();
            switch (cmbPrimeiroValor.SelectedValue)
            {
                case MoedaHelper.Dolar:
                    {
                        var valorConvertido = moedaservice.ConverterDolarEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $" {valorEmDolar} {MoedaHelper.Dolar} igual a ";
                        lblSegundoValor.Text = $" {valorConvertido}{MoedaHelper.Real}";
                        break;
                    }
                case MoedaHelper.Real:
                    {

                        var valorConvertido = moedaservice.ConverterRealEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $" {valorEmDolar} {MoedaHelper.Real} igual a ";
                        lblSegundoValor.Text = $" {valorConvertido}{MoedaHelper.Real}";
                        break;
                    }
                case MoedaHelper.Libra:
                    {

                        var valorConvertido = moedaservice.ConverterLibraEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $" {valorEmDolar} {MoedaHelper.Libra} igual a ";
                        lblSegundoValor.Text = $" {valorConvertido}{MoedaHelper.Real}";
                        break;
                    }
                case MoedaHelper.Euro:
                    {
                        var valorConvertido = moedaservice.ConverterEuroEmReal(valorEmDolar);
                        lblPrimeiroValor.Text = $" {valorEmDolar} {MoedaHelper.Euro} igual a ";
                        lblSegundoValor.Text = $" {valorConvertido}{MoedaHelper.Real}";
                        break;
                    }

            }
        }
    }
}
