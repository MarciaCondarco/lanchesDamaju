using MySql.Data.MySqlClient;

public static class ConexaoBanco
{
    private static readonly string connectionString =
        "Server=srv1438.hstgr.io;" +
        "Port=3306;" +
        "Database=u289366797_db_damaju;" +
        "Uid=u289366797_Damaju;" +
        "Pwd=Damaju123&;" +
        "convert zero datetime=True";

    public static MySqlConnection ObterConexao()
    {
        return new MySqlConnection(connectionString);
    }
}
