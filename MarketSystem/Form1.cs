using System.Data.SqlClient;

namespace MarketSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            var valor = Convert.ToDecimal(valueProduto.Text);
            var namoProduto = nameProduto.Text;

            string conexao = "Server=localhost;Database=SistemaProdutos;Trusted_Connection=True;";

            try
            {
                // Abre uma conex�o com o banco de dados
                using (SqlConnection connection = new SqlConnection(conexao))
                {
                    connection.Open();

                    // Cria a instru��o SQL para inserir o produto
                    string insertQuery = "INSERT INTO Produtos (Nome, Preco) VALUES (@Nome, @Preco)";

                    // Executa a instru��o SQL com os par�metros
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@Nome", namoProduto);
                        command.Parameters.AddWithValue("@Preco", valor);
                        command.ExecuteNonQuery();

                        label1.Text = "Cadastrado com sucesso";
                        
                    }
                }
            }
            catch (Exception ex)
            {
                // Captura e exibe qualquer exce��o que ocorra
                Console.WriteLine("Ocorreu um erro ao salvar: " + ex.Message);
            }

        }
    }
}
