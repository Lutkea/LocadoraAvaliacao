using System;
using System.Collections.Generic;
using Locadora_Cliente;
using Locadora_Filme;

namespace Locadora_Locacao
{
    public class Locacao
    {
        public int id;
        public DateTime dataLocacao;
        public DateTime dataDevolucao;
        public Cliente cliente;
        public Double valorTotal;
        public List<Filme> filmes = new List<Filme>();

        // Construtor de locação referente ao cliente
        public Locacao(int id, Cliente cliente)
        {
            this.id = id;
            this.cliente = cliente;
            this.dataLocacao = DateTime.Now;
            this.dataDevolucao = this.devolver(this.dataLocacao, this.cliente.diasDevolucao);
            cliente.locacao.Add(this);
        }


        // Retorna a data de devolução
        public DateTime devolver(DateTime dataLocacao, int diasDevolucao)
        {
            return dataLocacao.AddDays(diasDevolucao);
        }

        // Adiciona filme a lista de locação do cliente
        public void adicionarFilme(Filme filme)
        {
            this.filmes.Add(filme);
            filme.locacoes.Add(this);
        }

        // Calcula o valor da locação 
        public double valorLocacao()
        {
            double valor = 0;
            foreach (Filme filme in this.filmes)
            {
                valor += filme.valor;
            }

            return valor;
        }
        // Método com a Quantidade de Filmes Locados

        public int QtdeFilmesLoc()
        {
            return (this.filmes.Count);
        }

        // Método de cálculo para devolver
        public String calculoData()
        {
            DateTime dataAtual = DateTime.Now;

            return dataAtual.AddDays(cliente.diasDevolucao).ToString("dddd, dd MMMM yyyy");

        }
    }
}


