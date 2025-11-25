
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareV1MaestroRunArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::AI21.CreateMaestroRunsPayload request);
        partial void PrepareV1MaestroRunRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::AI21.CreateMaestroRunsPayload request);
        partial void ProcessV1MaestroRunResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1MaestroRunResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Create Maestro Run
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.MaestroRunResult> V1MaestroRunAsync(
            global::AI21.CreateMaestroRunsPayload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1MaestroRunArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::AI21.PathBuilder(
                path: "/studio/v1/maestro/runs",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1MaestroRunRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1MaestroRunResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::AI21.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::AI21.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        var __contentStream_422 = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = await global::AI21.HTTPValidationError.FromJsonStreamAsync(__contentStream_422, JsonSerializerContext).ConfigureAwait(false);
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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessV1MaestroRunResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::AI21.MaestroRunResult.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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

                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::AI21.MaestroRunResult.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::AI21.ApiException(
                        message: __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }

        /// <summary>
        /// Create Maestro Run
        /// </summary>
        /// <param name="input"></param>
        /// <param name="outputType"></param>
        /// <param name="models"></param>
        /// <param name="tools"></param>
        /// <param name="toolResources"></param>
        /// <param name="context"></param>
        /// <param name="requirements"></param>
        /// <param name="budget"></param>
        /// <param name="verbose">
        /// Default Value: false
        /// </param>
        /// <param name="include"></param>
        /// <param name="structuredRagEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="dynamicPlanningEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="payloadType">
        /// Default Value: maestro_run
        /// </param>
        /// <param name="customRetrievalConfigs"></param>
        /// <param name="responseLanguage">
        /// Default Value: unset
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.MaestroRunResult> V1MaestroRunAsync(
            global::AI21.AnyOf<global::System.Collections.Generic.IList<global::AI21.Message>, string> input,
            object? outputType = default,
            global::System.Collections.Generic.IList<string>? models = default,
            global::System.Collections.Generic.IList<global::AI21.ToolsItem>? tools = default,
            global::AI21.ToolResource? toolResources = default,
            object? context = default,
            global::System.Collections.Generic.IList<global::AI21.LanguageStudioApiServerDataTypesExecutionEngineRequirement>? requirements = default,
            global::AI21.CreateMaestroRunsPayloadBudget? budget = default,
            bool? verbose = default,
            global::System.Collections.Generic.IList<string>? include = default,
            bool? structuredRagEnabled = default,
            bool? dynamicPlanningEnabled = default,
            global::AI21.MaestroPayloadType? payloadType = default,
            global::System.Collections.Generic.IList<object>? customRetrievalConfigs = default,
            global::AI21.CreateMaestroRunsPayloadResponseLanguage? responseLanguage = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AI21.CreateMaestroRunsPayload
            {
                Input = input,
                OutputType = outputType,
                Models = models,
                Tools = tools,
                ToolResources = toolResources,
                Context = context,
                Requirements = requirements,
                Budget = budget,
                Verbose = verbose,
                Include = include,
                StructuredRagEnabled = structuredRagEnabled,
                DynamicPlanningEnabled = dynamicPlanningEnabled,
                PayloadType = payloadType,
                CustomRetrievalConfigs = customRetrievalConfigs,
                ResponseLanguage = responseLanguage,
            };

            return await V1MaestroRunAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}