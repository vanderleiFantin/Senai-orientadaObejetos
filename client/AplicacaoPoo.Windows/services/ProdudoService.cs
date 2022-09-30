using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacaoPoo.Windows.services
{
    public class ProdudoService
    {
        
        public string? Nome { get; set; }
        public int Codigo { get; set; }
        public List<ProdudoService> ListaProdutosFake()
        {
            var lista = new List<ProdudoService>();
            lista.Add(new ProdudoService()
            {
                Nome = "Motor Quebrado",
                Codigo = 123
            });
            lista.Add(new ProdudoService()
            {
                Nome = "Rebimboca",
                Codigo = 124
            });
            lista.Add(new ProdudoService()
            {
                Nome = "Canoa Furada",
                Codigo = 125
            });
            lista.Add(new ProdudoService()
            {
                Nome = "Bike sem Roda",
                Codigo = 126
            });
            

        }
    }
}
        
    

