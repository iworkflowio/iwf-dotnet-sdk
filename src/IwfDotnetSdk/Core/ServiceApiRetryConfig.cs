using System;

namespace IwfDotnetSdk.Core
{
    public record ServiceApiRetryConfig(
        int InitialIntervalMillis,
        int MaximumIntervalMillis,
        int MaximumAttempts)
    {
        public static ServiceApiRetryConfig Default => new(
            100,
            1000, // 1 second
            10
        );
    }
}