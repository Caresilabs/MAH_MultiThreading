
namespace Assignment2
{
    /// <summary>
    /// A buffer object containing 1 object instance.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Buffer<T>
    {
        /// <summary>
        /// The stored data
        /// </summary>
        protected T data;

        /// <summary>
        /// Does the buffer contain any data?
        /// </summary>
        protected bool hasData;

        /// <summary>
        /// Get the buffer data
        /// </summary>
        /// <param name="data">Data if available</param>
        /// <returns>If the process was successfull</returns>
        public abstract bool GetData(out T data);

        /// <summary>
        /// Set the buffer data
        /// </summary>
        /// <param name="data">The data to set</param>
        /// <returns>If the process was successfull</returns>
        public abstract bool SetData(T data);
    }
}
