using System;
using Sistema_de_Produtos; // Namespace contendo a classe Produtos
using System.IO; // Não utilizado neste contexto
using System.Data.SqlClient; // Para interagir com o banco de dados SQL Server

class Program
{
    public static void Main(string[] args)
    {
        // Cria um objeto para armazenar os dados do produto
        Produtos produtos = new Produtos();

        // String de conexão com o banco de dados
        string conexao = "Server=localhost;Database=Nome-banco-de-dados;Trusted_Connection=True;";

        try
        {
            // Abre uma conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(conexao))
            {
                connection.Open();

                // Obtém os dados do produto do usuário
                Console.WriteLine("Digite o Nome do Produto: ");
                produtos.nomeProduto = Console.ReadLine();
                Console.WriteLine("Digite o valor dele");
                produtos.Valor = decimal.Parse(Console.ReadLine());

                // Cria a instrução SQL para inserir o produto
                string insertQuery = "INSERT INTO Produtos (Nome, Preco) VALUES (@Nome, @Preco)";

                // Executa a instrução SQL com os parâmetros
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Nome", produtos.nomeProduto);
                    command.Parameters.AddWithValue("@Preco", produtos.Valor);
                    command.ExecuteNonQuery();

                    Console.WriteLine("Produto inserido com sucesso!");
                }
            }
        }
        catch (Exception ex)
        {
            // Captura e exibe qualquer exceção que ocorra
            Console.WriteLine("Ocorreu um erro ao salvar: " + ex.Message);
        }
    }
}