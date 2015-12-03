namespace Assignment3
{
    /// <summary>
    /// Interface for a ongoing thread.
    /// </summary>
    public interface Runnable
    {
        /// <summary>
        /// Is the thread running?
        /// </summary>
        bool IsRunning { get; set; }

        /// <summary>
        /// Start the runnable
        /// </summary>
        /// <returns></returns>
        bool Start();

        /// <summary>
        /// Stop the runnable
        /// </summary>
        /// <returns></returns>
        bool Stop();

        /// <summary>
        /// Stop and wait for it to complete
        /// </summary>
        /// <returns></returns>
        bool StopAndJoin();
    }
}
