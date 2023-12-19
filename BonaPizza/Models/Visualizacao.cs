using MySqlConnector;
namespace BonaPizza.Models
{
    public class Visualizacao
    {
        
        
        private readonly static string _conn = "server=*;user=*;password=*;database=*;";

        public static void Salvar()
        {
            var sql = "INSERT INTO VISITAS(DATA_ENTRADA) VALUES(NOW())";
            try
            {
                using (var cn = new MySqlConnection(_conn))
                {
                    cn.Open();
                    using (var cmd = new MySqlCommand(sql, cn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine("Falha!" + ex.Message);
            }
        }
    }
}
