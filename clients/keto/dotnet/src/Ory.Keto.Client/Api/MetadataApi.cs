/*
 * Ory Keto API
 *
 * Documentation for all of Ory Keto's REST APIs. gRPC is documented separately. 
 *
 * The version of the OpenAPI document: v0.11.0-alpha.0
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Ory.Keto.Client.Client;
using Ory.Keto.Client.Model;

namespace Ory.Keto.Client.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Return Running Software Version.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoInlineResponse2001</returns>
        KetoInlineResponse2001 GetVersion();

        /// <summary>
        /// Return Running Software Version.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoInlineResponse2001</returns>
        ApiResponse<KetoInlineResponse2001> GetVersionWithHttpInfo();
        /// <summary>
        /// Check HTTP Server Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoInlineResponse200</returns>
        KetoInlineResponse200 IsAlive();

        /// <summary>
        /// Check HTTP Server Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoInlineResponse200</returns>
        ApiResponse<KetoInlineResponse200> IsAliveWithHttpInfo();
        /// <summary>
        /// Check HTTP Server and Database Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoInlineResponse200</returns>
        KetoInlineResponse200 IsReady();

        /// <summary>
        /// Check HTTP Server and Database Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoInlineResponse200</returns>
        ApiResponse<KetoInlineResponse200> IsReadyWithHttpInfo();
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Return Running Software Version.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoInlineResponse2001</returns>
        System.Threading.Tasks.Task<KetoInlineResponse2001> GetVersionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Return Running Software Version.
        /// </summary>
        /// <remarks>
        /// This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoInlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<KetoInlineResponse2001>> GetVersionWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Check HTTP Server Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoInlineResponse200</returns>
        System.Threading.Tasks.Task<KetoInlineResponse200> IsAliveAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check HTTP Server Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoInlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<KetoInlineResponse200>> IsAliveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Check HTTP Server and Database Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoInlineResponse200</returns>
        System.Threading.Tasks.Task<KetoInlineResponse200> IsReadyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Check HTTP Server and Database Status
        /// </summary>
        /// <remarks>
        /// This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.
        /// </remarks>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoInlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<KetoInlineResponse200>> IsReadyWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMetadataApi : IMetadataApiSync, IMetadataApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MetadataApi : IMetadataApi
    {
        private Ory.Keto.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MetadataApi(string basePath)
        {
            this.Configuration = Ory.Keto.Client.Client.Configuration.MergeConfigurations(
                Ory.Keto.Client.Client.GlobalConfiguration.Instance,
                new Ory.Keto.Client.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MetadataApi(Ory.Keto.Client.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Ory.Keto.Client.Client.Configuration.MergeConfigurations(
                Ory.Keto.Client.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Ory.Keto.Client.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public MetadataApi(Ory.Keto.Client.Client.ISynchronousClient client, Ory.Keto.Client.Client.IAsynchronousClient asyncClient, Ory.Keto.Client.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Ory.Keto.Client.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Ory.Keto.Client.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Ory.Keto.Client.Client.ISynchronousClient Client { get; set; }

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
        public Ory.Keto.Client.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Ory.Keto.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Return Running Software Version. This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoInlineResponse2001</returns>
        public KetoInlineResponse2001 GetVersion()
        {
            Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse2001> localVarResponse = GetVersionWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return Running Software Version. This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoInlineResponse2001</returns>
        public Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse2001> GetVersionWithHttpInfo()
        {
            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = this.Client.Get<KetoInlineResponse2001>("/version", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVersion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Return Running Software Version. This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoInlineResponse2001</returns>
        public async System.Threading.Tasks.Task<KetoInlineResponse2001> GetVersionAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse2001> localVarResponse = await GetVersionWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Return Running Software Version. This endpoint returns the version of Ory Keto.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the version will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoInlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse2001>> GetVersionWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<KetoInlineResponse2001>("/version", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetVersion", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check HTTP Server Status This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoInlineResponse200</returns>
        public KetoInlineResponse200 IsAlive()
        {
            Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse200> localVarResponse = IsAliveWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check HTTP Server Status This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoInlineResponse200</returns>
        public Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse200> IsAliveWithHttpInfo()
        {
            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = this.Client.Get<KetoInlineResponse200>("/health/alive", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsAlive", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check HTTP Server Status This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoInlineResponse200</returns>
        public async System.Threading.Tasks.Task<KetoInlineResponse200> IsAliveAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse200> localVarResponse = await IsAliveWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check HTTP Server Status This endpoint returns a HTTP 200 status code when Ory Keto is accepting incoming HTTP requests. This status does currently not include checks whether the database connection is working.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of this service, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoInlineResponse200)</returns>
        public async System.Threading.Tasks.Task<Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse200>> IsAliveWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<KetoInlineResponse200>("/health/alive", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsAlive", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check HTTP Server and Database Status This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KetoInlineResponse200</returns>
        public KetoInlineResponse200 IsReady()
        {
            Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse200> localVarResponse = IsReadyWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check HTTP Server and Database Status This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KetoInlineResponse200</returns>
        public Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse200> IsReadyWithHttpInfo()
        {
            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = this.Client.Get<KetoInlineResponse200>("/health/ready", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsReady", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Check HTTP Server and Database Status This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of KetoInlineResponse200</returns>
        public async System.Threading.Tasks.Task<KetoInlineResponse200> IsReadyAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse200> localVarResponse = await IsReadyWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Check HTTP Server and Database Status This endpoint returns a HTTP 200 status code when Ory Keto is up running and the environment dependencies (e.g. the database) are responsive as well.  If the service supports TLS Edge Termination, this endpoint does not require the &#x60;X-Forwarded-Proto&#x60; header to be set.  Be aware that if you are running multiple nodes of Ory Keto, the health status will never refer to the cluster state, only to a single instance.
        /// </summary>
        /// <exception cref="Ory.Keto.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (KetoInlineResponse200)</returns>
        public async System.Threading.Tasks.Task<Ory.Keto.Client.Client.ApiResponse<KetoInlineResponse200>> IsReadyWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Ory.Keto.Client.Client.RequestOptions localVarRequestOptions = new Ory.Keto.Client.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Ory.Keto.Client.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Ory.Keto.Client.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }



            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<KetoInlineResponse200>("/health/ready", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("IsReady", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
