using System;
using System.Collections.Generic;

namespace IwfDotnetSdk.Core
{
    public class ClientOptions
    {
        public const string DefaultWorkerUrl = "http://localhost:8802";
        public const string WorkerUrlFromDocker = "http://host.docker.internal:8802";
        public const string DefaultServerUrl = "http://localhost:8801";

        public static readonly ClientOptions LocalDefault = Minimum(DefaultWorkerUrl, DefaultServerUrl);
        public static readonly ClientOptions DockerDefault = Minimum(WorkerUrlFromDocker, DefaultServerUrl);

        public string ServerUrl { get; }
        public string WorkerUrl { get; }
        public IObjectEncoder ObjectEncoder { get; }
        public int? LongPollApiMaxWaitTimeSeconds { get; }
        public Dictionary<string, string> RequestHeaders { get; }
        public ServiceApiRetryConfig ServiceApiRetryConfig { get; }

        public ClientOptions(
            string serverUrl,
            string workerUrl,
            IObjectEncoder objectEncoder,
            int? longPollApiMaxWaitTimeSeconds = null,
            Dictionary<string, string> requestHeaders = null,
            ServiceApiRetryConfig serviceApiRetryConfig = null)
        {
            ServerUrl = serverUrl ?? throw new ArgumentNullException(nameof(serverUrl));
            WorkerUrl = workerUrl ?? throw new ArgumentNullException(nameof(workerUrl));
            ObjectEncoder = objectEncoder ?? throw new ArgumentNullException(nameof(objectEncoder));
            LongPollApiMaxWaitTimeSeconds = longPollApiMaxWaitTimeSeconds;
            RequestHeaders = requestHeaders ?? new Dictionary<string, string>();
            ServiceApiRetryConfig = serviceApiRetryConfig ?? ServiceApiRetryConfig.Default;
        }

        public static ClientOptions Minimum(string workerUrl, string serverUrl)
        {
            return new ClientOptions(
                serverUrl: serverUrl,
                workerUrl: workerUrl,
                objectEncoder: new JsonObjectEncoder()
            );
        }
    }
}