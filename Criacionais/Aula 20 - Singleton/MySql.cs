namespace PadroesDeProjeto.Criacionais.Aula_20___Singleton;

public class MySql : IConexao
{
    private static MySql? _mySql = null;
    private string _host = "mysql:host=localhost;dbname=Bd";
    private string _user = "root";
    private string _password = "root";

    public static void ExecutarQuery(string query) => Console.WriteLine("A query \n" + query + "\nfoi executada");

    public void SetHost(string host) => _host = host;

    public void SetUser(string user) => _user = user;

    public void SetPassword(string password) => _password = password;

    public override string ToString() => $"{_host}:{_user}:{_password}";

    public static MySql GetInstance() => _mySql ??= new MySql();
}