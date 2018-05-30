using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueMercadoriaEngine.Models
{
    public class EstoqueModel
    {
        private List<MercadoriaModel> mercadorias;

        public List<MercadoriaModel> Mercadorias
        {
            get
            {
                if (mercadorias == null)
                    mercadorias = new List<MercadoriaModel>();

                return mercadorias;
            }
        }

        public double GetValorTotal()
        {
            double ValorTotal = 0;

            foreach (MercadoriaModel Mercadoria in this.mercadorias)
            {
                ValorTotal += Mercadoria.GetValorTotal();
            }

            return ValorTotal;
        }

        public int GetQtdTotal()
        {
            int QtdTotal = 0;
            foreach (MercadoriaModel Mercadoria in this.mercadorias)
            {
                QtdTotal += Mercadoria.Qtd;
            }

            return QtdTotal;
        }

        public double GetMediaValor()
        {
            return Math.Round(GetValorTotal() / GetQtdTotal(), 2);
        }
    }
}
