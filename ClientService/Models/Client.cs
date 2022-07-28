using System.Data.SqlClient;

namespace ClientService.Models
{
    public class Client
    {
        public Client()
        {
        }

        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set;}

        public static List<Client> All()
        {
            var list = new List<Client>();

            SqlConnection conn = new SqlConnection(Connect.Datas);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from clientes", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Client
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Telefone = reader["telefone"].ToString(),
                    Endereco = reader["Endereco"].ToString(),
                });
            }

            conn.Close();
            conn.Dispose();

            return list;
        }
    }
}
