using System;
using System.Collections.Generic;
using Locacao_Filme;
using Locadora_Filme;


namespace Locadora_Cliente{
            
    public class Cliente{
    public String id;
    public String nome;
    public DateTime dtNasc;
     public String cpf;
    public int diasDevolucao;
    public List<Locacao> locacoes = new List<Locacao>();

        public Cliente(String id, String nome, DateTime dtNasc, String cpf, int diasDevolucao){
            this.id = id;
            this.nome = nome;
            this.dtNasc = dtNasc;
            this.cpf = cpf;
            this.diasDevolucao = diasDevolucao;
        }

        public int filmesLocados(){
            int filmes = 0;

            foreach(Locacao locacao in this.locacoes){
                foreach (Filme filme in locacao.filmes)
                {
                    filmes++;
                }
            }

            return filmes;
        }
    }
}

