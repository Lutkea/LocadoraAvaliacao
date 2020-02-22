using System;
using System.Collections.Generic;
using Locadora_Locacao;

namespace Locadora_Filme
{
    public class Filme
    {
        public String id;
        public String nome;
        public String anoLancamento;
        public String sinopse;
        public double valor;
        public int estoque;
        public int locado;
        public List<Locacao> locacoes = new List<Locacao>();


        //construtor filme
        public Filme(String paramId, String nome, String anoLancamento, String sinopse, double valor, int estoque)
        {
            this.id = paramId;
            this.nome = nome;
            this.anoLancamento = anoLancamento;
            this.sinopse = sinopse;
            this.valor = valor;
            this.estoque = estoque;
            this.locado = 0;
        }

        // Método com a Quantidade de locações Realizadas
        public void filmeLocado()
        {
            this.estoque -= 1;
            this.locado += 1;
        }

        // Informações impressas dos filmes
        public void mostrarFilme()

        {
            Console.WriteLine("ID DO FILME: " + id);
            Console.WriteLine(" TÍTULO: " + nome);
            Console.WriteLine(" DATA DE LANÇAMENTO: " + anoLancamento);
            Console.WriteLine(" SINOPSE: " + sinopse);
            Console.WriteLine(" VALOR DA LOCAÇÃO: R$ " + valor);
            Console.WriteLine(" QUANTIDADE EM ESTOQUE: " + estoque);
            Console.WriteLine(" QTDE DE LOCAÇÕES REALIZADAS: " + locacoes.Count);

        }
    }
}


