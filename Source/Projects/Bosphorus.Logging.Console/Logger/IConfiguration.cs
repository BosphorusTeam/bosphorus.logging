namespace Bosphorus.Logging.Console
{
    public interface IConfiguration<TLog>
    {
        string LogFormat { get; }
    }
}
