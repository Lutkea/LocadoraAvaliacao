using System;
using Locadora_Filme;
using Locadora_Cliente;
using Locacao_Filme;

namespace BlockBuster{
    class Locadora{

        static void Main(string[] args){
        DateTime calendario = new DateTime(2020, 2, 18);

        Cliente cliente1 = new Cliente("0", "Adamastor", calendario, "0", 3);

        Locacao locacao1 = new Locacao("0", cliente1);
        
        Filme filme1 = new Filme("0", "Coringa", "2019", "Matar o Bátima", 19.5, 1);
        Filme filme2 = new Filme("1", "Rei Leão", "2019", "SIMBÁ", 21, 1);

        locacao1.adicionarFilme(filme1);
        locacao1.adicionarFilme(filme2);

        Locacao locacao2 = new Locacao("1", cliente1);
        locacao2.adicionarFilme(filme1);
        locacao2.adicionarFilme(filme2);

 // imprime na tela os filmes, valores e quantidade de locações    
        Console.WriteLine("Filmes Locados: " + cliente1.filmesLocados());
        Console.WriteLine("Valor da Locação: " + locacao1.valorLocacao());
        Console.WriteLine("Quantidade de locações: " + filme1.qtdLocacoes());

        }
    }
}