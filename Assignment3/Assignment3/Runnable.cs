namespace Assignment3
{
    public interface Runnable
    {
        bool IsRunning { get; set; }

        bool Start();

        bool Stop();

        bool StopAndJoin();
    }
}
