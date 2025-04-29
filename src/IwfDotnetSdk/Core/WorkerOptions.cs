namespace IwfDotnetSdk.Core
{
    /// <summary>
    /// Options for the workflow worker
    /// </summary>
    public record WorkerOptions
    {
        /// <summary>
        /// Gets the object encoder
        /// </summary>
        public IObjectEncoder ObjectEncoder { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkerOptions"/> class
        /// </summary>
        /// <param name="objectEncoder">The object encoder</param>
        public WorkerOptions(IObjectEncoder objectEncoder)
        {
            ObjectEncoder = objectEncoder ?? throw new System.ArgumentNullException(nameof(objectEncoder));
        }

        /// <summary>
        /// Gets the default worker options
        /// </summary>
        public static WorkerOptions DefaultOptions => new WorkerOptions(new JsonObjectEncoder());

        /// <summary>
        /// Creates a minimum worker options with the specified object encoder
        /// </summary>
        /// <param name="objectEncoder">The object encoder</param>
        /// <returns>The worker options</returns>
        public static WorkerOptions Minimum(IObjectEncoder objectEncoder)
        {
            return new WorkerOptions(objectEncoder);
        }
    }
}