using System;
using System.Collections.Generic;
using Locadora_Locacao;
using Locadora_Filme;
using System.Linq;

namespace Locadora_Cliente{
            
    public class Cliente{
        public int id;
        public String nome;
        public String dtNasc;
        public String cpf;
        public int diasDevolucao;
        public int filmesLoc;
        public List<Locacao> locacao = new List<Locacao>();
        
        // construtor cliente
        public Cliente(int id, String nome, String dtNasc, String cpf, int diasDevolucao){
            this.id = id;
            this.nome = nome;
            this.dtNasc = dtNasc;
            this.cpf = cpf;
            this.diasDevolucao = diasDevolucao;
        }

        public int filmesLocados(){
            int filmes = 0;

            foreach(Locacao locacao in this.locacao){
                foreach(Filme filme in locacao.filmes)
                {
                    filmes++;
                }
            }
             return filmes;
        }

            // Impressão Dados do CLiente
            public void mostrarCliente()
            {
                Console.WriteLine("Cliente");
                Console.WriteLine("ID DO CLIENTE: " + id);
                Console.WriteLine("NOME COMPLETO: " + nome);
                Console.WriteLine("DATA DE NASCIMENTO: " + dtNasc);
                Console.WriteLine("CPF: " + cpf);
                Console.WriteLine("DIAS PARA DEVOLUÇÃO: " + diasDevolucao);
                Console.WriteLine("QUANTIDADE DE LOCAÇÕES: " + locacao.Count);
            }
            // Adição de Locações
            public void adicionarLocacao(Locacao locacao)
            {
                this.locacao.Add(locacao);
            }

            // Lista de locações
            public int getLocacoes()
            {
                int qtd = 0;

                foreach (Locacao locacao in this.locacao)
                {
                    foreach (Filme filme in locacao.filmes)
                    {
                        qtd++;
                    }
                }

                return qtd;
        }
    }
}

