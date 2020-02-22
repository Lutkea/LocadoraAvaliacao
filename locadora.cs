using System;
using Locadora_Filme;
using Locadora_Cliente;
using Locadora_Locacao;

namespace BlockBuster
{
    class Locadora
    {

        public static void Main(String[] args)
        {
			Console.WriteLine("Bem vindo à BlockBuster ADS");

            //Informações das clientes
            Cliente cliente1 = new Cliente(1, "Chica da Silva", "19/08/1998", "123.456.789.00", 3);
            Cliente cliente2 = new Cliente(2, "Maria Aparecida", "21/11/1994", "987.654.321.99", 4);
            Cliente cliente3 = new Cliente(3, "Joana Oliveira", "25/04/2000", "125.954.785-22", 2);
            Cliente cliente4 = new Cliente(4, "Juliana Costa", "10/01/1985", "520.412.021-87", 1);
            Cliente cliente5 = new Cliente(5, "Anita Vieira", "15/01/1970", "025.365.851-74", 6);

            //Informações dos filmes             
            Filme filme1 = new Filme("0", "Peixe Grande e Suas Histórias Maravilhosas", "2019", "Contar Histórias", 19.5, 1);
            Filme filme2 = new Filme("1", "Olhos Grandes", "2019", "Mulher artista, resista", 21, 1);
            Filme filme3 = new Filme("2", "Star Wars", "1990", "Uns loucos no espaço arrumando briga", 21, 1);
            Filme filme4 = new Filme("3", "Bacurau", "2019", "Filme brasileiro maravilhoso", 21, 1);
            Filme filme5 = new Filme("4", "A orfã", "2002", "História sobre uma suposta criança bem maluca", 21, 1);
            Filme filme6 = new Filme("5", "Coringa", "2019", "Assim que nasce o coronga", 21, 1);
            Filme filme7 = new Filme("6", "Anabelle", "2018", "Boneca possuída", 21, 1);
            Filme filme8 = new Filme("7", "Parasita", "2019", "Ganhou o oscar", 21, 1);
            Filme filme9 = new Filme("8", "O grito", "1999", "Muita gente gritando", 21, 1);
            Filme filme10 = new Filme("9", "Frozen", "2020", "Imagem do fim da terra, paredão de gelo", 21, 1);

            Locacao locacao;
            int idCliente = 0;
			
			//seleção de clientes
            do
            {
            	Console.WriteLine("\nQual o ID do Cliente?: ");

            	String entrada = Console.ReadLine();
            	idCliente = Convert.ToInt32(entrada);

                switch (idCliente)
            	{
            		case 1:
                        locacao = new Locacao(1, cliente1);
                        locacao.adicionarFilme(filme1);        
            			locacao.adicionarFilme(filme5);        
            			locacao.adicionarFilme(filme3); 
            			cliente1.mostrarCliente();                             
            			filme1.mostrarFilme();                                           
            			filme5.mostrarFilme();            
            			filme3.mostrarFilme();
            			Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.valorLocacao());
            			Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
            			Console.WriteLine(" Quantidade de Filmes: " + locacao.QtdeFilmesLoc());
            			break;

 		       		case 2:
            			locacao = new Locacao(2, cliente2);
						locacao.adicionarFilme(filme2);
            			locacao.adicionarFilme(filme7);
            			locacao.adicionarFilme(filme10);
						cliente2.mostrarCliente();
            			filme2.mostrarFilme();
            			filme7.mostrarFilme();
						filme10.mostrarFilme();
            			Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.valorLocacao());
            			Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
            			Console.WriteLine(" Quantidade de Filmes: " + locacao.QtdeFilmesLoc());
            			break;

            		case 3:
            			
            			locacao = new Locacao(3, cliente3);
						locacao.adicionarFilme(filme3);
            			locacao.adicionarFilme(filme6);
            			locacao.adicionarFilme(filme7);
						cliente3.mostrarCliente();
            			filme3.mostrarFilme();
            			filme6.mostrarFilme();
            			filme7.mostrarFilme();
            			filme8.mostrarFilme();
            			Console.WriteLine(" Total das Locações: R$ " + locacao.valorLocacao());
            			Console.WriteLine(" Devolver em: " + locacao.calculoData());
            			Console.WriteLine(" Quantidade de Filmes: " + locacao.QtdeFilmesLoc());
            			break;

            		case 4:
            			locacao = new Locacao(4, cliente4);
						locacao.adicionarFilme(filme4);
            			locacao.adicionarFilme(filme9);
            			locacao.adicionarFilme(filme10);
						cliente4.mostrarCliente();
            			filme4.mostrarFilme();
            			filme9.mostrarFilme();
						filme10.mostrarFilme();
            			Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.valorLocacao());
            			Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
            			Console.WriteLine(" Quantidade de FILMEES: " + locacao.QtdeFilmesLoc());
            			break;

            		case 5:
            			locacao = new Locacao(5, cliente5);
						locacao.adicionarFilme(filme1);
            			locacao.adicionarFilme(filme5);
            			locacao.adicionarFilme(filme10);
            			locacao.adicionarFilme(filme10);
						cliente5.mostrarCliente();
            			filme1.mostrarFilme();
            			filme5.mostrarFilme();
            			filme10.mostrarFilme();
						filme10.mostrarFilme();
            			Console.WriteLine(" TOTAL DAS LOCAÇÕES: R$ " + locacao.valorLocacao());
            			Console.WriteLine(" DEVOLVER EM: " + locacao.calculoData());
            			Console.WriteLine(" Quantidade de FILMEES: " + locacao.QtdeFilmesLoc());
            			break;
  
            	}
            } while (idCliente <= 5);
        }
    }
}