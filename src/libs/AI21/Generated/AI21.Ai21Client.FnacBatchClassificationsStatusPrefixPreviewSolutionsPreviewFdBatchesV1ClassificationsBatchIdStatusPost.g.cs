
#nullable enable

namespace AI21
{
    public partial class Ai21Client
    {


        private static readonly global::AI21.EndPointSecurityRequirement s_FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostSecurityRequirement0 =
            new global::AI21.EndPointSecurityRequirement
            {
                Authorizations = new global::AI21.EndPointAuthorizationRequirement[]
                {                    new global::AI21.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "HttpBearer",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::AI21.EndPointSecurityRequirement[] s_FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostSecurityRequirements =
            new global::AI21.EndPointSecurityRequirement[]
            {                s_FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostSecurityRequirement0,
            };
        partial void PrepareFnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string batchId);
        partial void PrepareFnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string batchId);
        partial void ProcessFnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessFnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Fnac Batch Classifications Status Prefix Preview
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<string> FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostAsync(
            string batchId,
            global::AI21.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareFnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostArguments(
                httpClient: HttpClient,
                batchId: ref batchId);


            var __authorizations = global::AI21.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostSecurityRequirements,
                operationName: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostAsync");

            using var __timeoutCancellationTokenSource = global::AI21.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::AI21.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::AI21.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {
                            var __pathBuilder = new global::AI21.PathBuilder(
                                path: $"/solutions-preview/fd/batches/v1/classifications/{batchId}/status",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::AI21.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }
                global::AI21.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareFnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    batchId: batchId);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::AI21.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::AI21.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPost",
                                methodName: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostAsync",
                                pathTemplate: "$\"/solutions-preview/fd/batches/v1/classifications/{batchId}/status\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::AI21.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AI21.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPost",
                                methodName: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostAsync",
                                pathTemplate: "$\"/solutions-preview/fd/batches/v1/classifications/{batchId}/status\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AI21.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::AI21.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::AI21.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AI21.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPost",
                                methodName: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostAsync",
                                pathTemplate: "$\"/solutions-preview/fd/batches/v1/classifications/{batchId}/status\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::AI21.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessFnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::AI21.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::AI21.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPost",
                                methodName: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostAsync",
                                pathTemplate: "$\"/solutions-preview/fd/batches/v1/classifications/{batchId}/status\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::AI21.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::AI21.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPost",
                                methodName: "FnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostAsync",
                                pathTemplate: "$\"/solutions-preview/fd/batches/v1/classifications/{batchId}/status\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::AI21.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::AI21.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::AI21.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::AI21.ApiException<global::AI21.HTTPValidationError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessFnacBatchClassificationsStatusPrefixPreviewSolutionsPreviewFdBatchesV1ClassificationsBatchIdStatusPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return __content;
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::AI21.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return __content;
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::AI21.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}