/*
 * ORY Oathkeeper
 *
 * ORY Oathkeeper is a reverse proxy that checks the HTTP Authorization for validity against a set of rules. This service uses Hydra to validate access tokens and policies.
 *
 * The version of the OpenAPI document: v0.40.2
 * Contact: hi@ory.am
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ory.Oathkeeper.Client.Client;
using Ory.Oathkeeper.Client.Model;

namespace Ory.Oathkeeper.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Check alive status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OathkeeperHealthStatus</returns>
        OathkeeperHealthStatus IsInstanceAlive();

        /// <summary>
        /// Check alive status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OathkeeperHealthStatus</returns>
        ApiResponse<OathkeeperHealthStatus> IsInstanceAliveWithHttpInfo();
        /// <summary>
        /// Check readiness status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OathkeeperHealthStatus</returns>
        OathkeeperHealthStatus IsInstanceReady();

        /// <summary>
        /// Check readiness status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OathkeeperHealthStatus</returns>
        ApiResponse<OathkeeperHealthStatus> IsInstanceReadyWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Check alive status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OathkeeperHealthStatus</returns>
        System.Threading.Tasks.Task<OathkeeperHealthStatus> IsInstanceAliveAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check alive status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OathkeeperHealthStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<OathkeeperHealthStatus>> IsInstanceAliveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Check readiness status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OathkeeperHealthStatus</returns>
        System.Threading.Tasks.Task<OathkeeperHealthStatus> IsInstanceReadyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check readiness status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OathkeeperHealthStatus)</returns>
        System.Threading.Tasks.Task<ApiResponse<OathkeeperHealthStatus>> IsInstanceReadyWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHealthApi : IHealthApiSync, IHealthApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HealthApi : IHealthApi
    {
        private Ory.Oathkeeper.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HealthApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HealthApi(string basePath)
        {
            this.Configuration = Ory.Oathkeeper.Client.Client.Configuration.MergeConfigurations(
                Ory.Oathkeeper.Client.Client.GlobalConfiguration.Instance,
                new Ory.Oathkeeper.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ory.Oathkeeper.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Oathkeeper.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ory.Oathkeeper.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HealthApi(Ory.Oathkeeper.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ory.Oathkeeper.Client.Client.Configuration.MergeConfigurations(
                Ory.Oathkeeper.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ory.Oathkeeper.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Oathkeeper.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ory.Oathkeeper.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HealthApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public HealthApi(Ory.Oathkeeper.Client.Client.ISynchronousClient client, Ory.Oathkeeper.Client.Client.IAsynchronousClient asyncClient, Ory.Oathkeeper.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ory.Oathkeeper.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ory.Oathkeeper.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ory.Oathkeeper.Client.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Ory.Oathkeeper.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ory.Oathkeeper.Client.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Check alive status This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OathkeeperHealthStatus</returns>
        public OathkeeperHealthStatus IsInstanceAlive()
        {
            Ory.Oathkeeper.Client.Client.ApiResponse<OathkeeperHealthStatus> localVarResponse = IsInstanceAliveWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check alive status This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OathkeeperHealthStatus</returns>
        public Ory.Oathkeeper.Client.Client.ApiResponse<OathkeeperHealthStatus> IsInstanceAliveWithHttpInfo()
        {
            Ory.Oathkeeper.Client.Client.RequestOptions localVarRequestOptions = new Ory.Oathkeeper.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Oathkeeper.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Oathkeeper.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = this.Client.Get<OathkeeperHealthStatus>("/health/alive", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsInstanceAlive", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check alive status This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OathkeeperHealthStatus</returns>
        public async System.Threading.Tasks.Task<OathkeeperHealthStatus> IsInstanceAliveAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Oathkeeper.Client.Client.ApiResponse<OathkeeperHealthStatus> localVarResponse = await IsInstanceAliveWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check alive status This endpoint returns a 200 status code when the HTTP server is up running. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OathkeeperHealthStatus)</returns>
        public async System.Threading.Tasks.Task<Ory.Oathkeeper.Client.Client.ApiResponse<OathkeeperHealthStatus>> IsInstanceAliveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Oathkeeper.Client.Client.RequestOptions localVarRequestOptions = new Ory.Oathkeeper.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Oathkeeper.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Oathkeeper.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<OathkeeperHealthStatus>("/health/alive", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsInstanceAlive", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check readiness status This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>OathkeeperHealthStatus</returns>
        public OathkeeperHealthStatus IsInstanceReady()
        {
            Ory.Oathkeeper.Client.Client.ApiResponse<OathkeeperHealthStatus> localVarResponse = IsInstanceReadyWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check readiness status This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of OathkeeperHealthStatus</returns>
        public Ory.Oathkeeper.Client.Client.ApiResponse<OathkeeperHealthStatus> IsInstanceReadyWithHttpInfo()
        {
            Ory.Oathkeeper.Client.Client.RequestOptions localVarRequestOptions = new Ory.Oathkeeper.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Oathkeeper.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Oathkeeper.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = this.Client.Get<OathkeeperHealthStatus>("/health/ready", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsInstanceReady", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check readiness status This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of OathkeeperHealthStatus</returns>
        public async System.Threading.Tasks.Task<OathkeeperHealthStatus> IsInstanceReadyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Oathkeeper.Client.Client.ApiResponse<OathkeeperHealthStatus> localVarResponse = await IsInstanceReadyWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check readiness status This endpoint returns a 200 status code when the HTTP server is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Oathkeeper.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (OathkeeperHealthStatus)</returns>
        public async System.Threading.Tasks.Task<Ory.Oathkeeper.Client.Client.ApiResponse<OathkeeperHealthStatus>> IsInstanceReadyWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Oathkeeper.Client.Client.RequestOptions localVarRequestOptions = new Ory.Oathkeeper.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Oathkeeper.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Oathkeeper.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<OathkeeperHealthStatus>("/health/ready", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsInstanceReady", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
