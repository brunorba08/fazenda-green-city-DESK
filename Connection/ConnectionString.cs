using System.Configuration;
using System.Data.SqlClient;
namespace FazendaGroup1 {
    public class ConnectionString {
        public static string ObterConexao() {
            return ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
        }
    }
}
