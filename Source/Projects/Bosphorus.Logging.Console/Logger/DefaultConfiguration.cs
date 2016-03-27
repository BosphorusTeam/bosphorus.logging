namespace Bosphorus.Logging.Console.Logger
{
    public class DefaultConfiguration<TLog> : IConfiguration<TLog>
    {
        public string LogFormat => "DateTime: {0}, Level:{1}, Message:{2}";
    }
}