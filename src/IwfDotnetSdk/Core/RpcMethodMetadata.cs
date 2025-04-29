namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Metadata about an RPC method
    /// </summary>
    internal record RpcMethodMetadata
    {
        /// <summary>
        /// Gets whether the method has input
        /// </summary>
        public bool HasInput { get; }

        /// <summary>
        /// Gets the input parameter index
        /// </summary>
        public int InputIndex { get; }

        /// <summary>
        /// Gets whether the method uses persistence
        /// </summary>
        public bool UsesPersistence { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RpcMethodMetadata"/> class
        /// </summary>
        /// <param name="hasInput">Whether the method has input</param>
        /// <param name="inputIndex">The input parameter index</param>
        /// <param name="usesPersistence">Whether the method uses persistence</param>
        public RpcMethodMetadata(bool hasInput, int inputIndex, bool usesPersistence)
        {
            HasInput = hasInput;
            InputIndex = inputIndex;
            UsesPersistence = usesPersistence;
        }
    }
}