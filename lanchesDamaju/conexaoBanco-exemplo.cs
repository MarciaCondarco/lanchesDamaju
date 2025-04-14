using MySql.Data.MySqlClient;

public static class conexaobanco
{
    private static readonly string 
        connectionstring = "Server=127.0.0.1;" +
        "Port=3306;" +
        "Database=db_lanchesdamaju;" +
        "Uid=root;" +
        "Pwd=; " +
        "convert zero datetime=True";

    public static MySqlConnection cbterconexao()
    {
        return new MySqlConnection(connectionstring);
    }
}

