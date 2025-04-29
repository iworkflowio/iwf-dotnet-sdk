namespace IwfDotnetSdk.Core.Command
{
    /// <summary>
    /// Interface for all workflow commands
    /// </summary>
    public interface IBaseCommand
    {
        /// <summary>
        /// Gets the command ID
        /// </summary>
        string? CommandId { get; }
    }
}