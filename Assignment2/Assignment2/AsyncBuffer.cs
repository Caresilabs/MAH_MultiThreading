
namespace Assignment2
{
    /// <summary>
    /// An asynchronous buffer. NOT THREAD SAFE!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class AsyncBuffer<T> : Buffer<T>
    {
        /// <summary>
        /// Get the data asynchronous.
        /// </summary>
        /// <returns></returns>
        public override bool GetData(out T data)
        {
            data = this.data;
            hasData = false;
            return true;
        }

        /// <summary>
        /// Set the data asynchronous.
        /// </summary>
        /// <returns></returns>
        public override bool SetData(T data)
        {
            this.data = data;
            hasData = true;
            return true;
        }
    }
}
