using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Windows.services
{
    //static
    //partial
    //abstract
    public class ConverterMoedaService
    {
        decimal CotacaoDolar = 5.25m;
        decimal CotacaoLibra = 6.15m;
        decimal CotacaoEuro = 6.0m;
        decimal CotacaoReal = 1.0m;
        public decimal ConverterDolarEmReal (decimal valor)
        {
            return valor*CotacaoDolar;
        }
        public decimal ConverterLibraEmReal(decimal valor)
        {
            return valor * CotacaoLibra;
        }
        public decimal ConverterEuroEmReal(decimal valor)
        {
            return valor * CotacaoEuro;
        }
        public decimal ConverterRealEmReal(decimal valor)
        {
            return valor * CotacaoReal;
        }
        public decimal ConverterRealEmDolar(decimal valor)
        {
            return valor / CotacaoDolar;
        }
        public decimal ConverterRealEmLibras(decimal valor)
        {
            return valor / CotacaoLibra;
        }
        public decimal ConverterRealEmEuro(decimal valor) { return valor / CotacaoEuro; }
        public decimal ConverterDolarEmEuro(decimal valor) { return valor / CotacaoEuro; }
       

    }
}
