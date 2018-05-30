using System;
using System.Collections.Generic;
using System.Text;

namespace EstoqueMercadoriaEngine.Models
{
    public class MercadoriaModel
    {
        public const string EXCEPTION_MESSAGE_QTD_TOTAL_MENOR_0 = "Quantidade em estoque não pode ser menor que 0.";
        public const string EXCEPTION_MESSAGE_VALOR_MENOR_0 = "Valor da mercadoria não pode ser menor que 0.";

        private int qtd;
        private double valor;

        public MercadoriaModel(int qtd, double valor)
        {
            if (qtd < 0) throw new ArgumentException(EXCEPTION_MESSAGE_QTD_TOTAL_MENOR_0);
            if (valor < 0) throw new ArgumentException(EXCEPTION_MESSAGE_VALOR_MENOR_0);

            this.qtd = qtd;
            this.valor = valor;
        }
        public int Qtd
        {
            get { return qtd; } set { qtd = value; }
        }

        public double Valor
        {
            get { return valor; } set { valor = value; }
        }

        public double GetValorTotal()
        {
            return qtd * valor;
        }
    }
}
