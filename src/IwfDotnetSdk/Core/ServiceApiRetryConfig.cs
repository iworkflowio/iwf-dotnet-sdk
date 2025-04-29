using System;

namespace IwfDotnetSdk.Core
{
    public class ServiceApiRetryConfig
    {
        public int InitialIntervalMillis { get; }
        public int MaximumIntervalMillis { get; }
        public int MaximumAttempts { get; }

        public ServiceApiRetryConfig(
            int initialIntervalMillis,
            int maximumIntervalMillis,
            int maximumAttempts)
        {
            InitialIntervalMillis = initialIntervalMillis;
            MaximumIntervalMillis = maximumIntervalMillis;
            MaximumAttempts = maximumAttempts;
        }

        public static ServiceApiRetryConfig Default => new ServiceApiRetryConfig(
            initialIntervalMillis: 100,
            maximumIntervalMillis: 1000, // 1 second
            maximumAttempts: 10
        );
    }
}