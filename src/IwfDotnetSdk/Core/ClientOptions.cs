using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace IwfDotnetSdk.Core
{
    public record ClientOptions
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
        public IReadOnlyDictionary<string, string> RequestHeaders { get; }
        public ServiceApiRetryConfig ServiceApiRetryConfig { get; }

        public ClientOptions(
            string serverUrl,
            string workerUrl,
            IObjectEncoder objectEncoder,
            int? longPollApiMaxWaitTimeSeconds = null,
            IReadOnlyDictionary<string, string>? requestHeaders = null,
            ServiceApiRetryConfig? serviceApiRetryConfig = null)
        {
            ServerUrl = serverUrl ?? throw new ArgumentNullException(nameof(serverUrl));
            WorkerUrl = workerUrl ?? throw new ArgumentNullException(nameof(workerUrl));
            ObjectEncoder = objectEncoder ?? throw new ArgumentNullException(nameof(objectEncoder));
            LongPollApiMaxWaitTimeSeconds = longPollApiMaxWaitTimeSeconds;
            RequestHeaders = requestHeaders ?? ImmutableDictionary<string, string>.Empty;
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

        // Provides convenience methods for with-style updates
        public ClientOptions With(
            string? serverUrl = null,
            string? workerUrl = null,
            IObjectEncoder? objectEncoder = null,
            int? longPollApiMaxWaitTimeSeconds = null,
            IReadOnlyDictionary<string, string>? requestHeaders = null,
            ServiceApiRetryConfig? serviceApiRetryConfig = null)
        {
            return new ClientOptions(
                serverUrl: serverUrl ?? ServerUrl,
                workerUrl: workerUrl ?? WorkerUrl,
                objectEncoder: objectEncoder ?? ObjectEncoder,
                longPollApiMaxWaitTimeSeconds: longPollApiMaxWaitTimeSeconds ?? LongPollApiMaxWaitTimeSeconds,
                requestHeaders: requestHeaders ?? RequestHeaders,
                serviceApiRetryConfig: serviceApiRetryConfig ?? ServiceApiRetryConfig
            );
        }
    }
}