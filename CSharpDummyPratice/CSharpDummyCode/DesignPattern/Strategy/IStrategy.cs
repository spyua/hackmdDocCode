namespace DesignPattern.Strategy
{
    public interface IStrategy
    {
        string Write(string cmd);

        int Read();
    }
}
