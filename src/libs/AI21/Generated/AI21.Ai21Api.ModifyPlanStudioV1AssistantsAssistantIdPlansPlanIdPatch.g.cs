
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string assistantId,
            ref string planId,
            global::AI21.CreatePlanPayload request);
        partial void PrepareModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string assistantId,
            string planId,
            global::AI21.CreatePlanPayload request);
        partial void ProcessModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Modify Plan
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="planId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.Plan> ModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchAsync(
            string assistantId,
            string planId,
            global::AI21.CreatePlanPayload request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchArguments(
                httpClient: HttpClient,
                assistantId: ref assistantId,
                planId: ref planId,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/studio/v1/assistants/{assistantId}/plans/{planId}",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: new global::System.Net.Http.HttpMethod("PATCH"),
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
            PrepareModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                assistantId: assistantId,
                planId: planId,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::AI21.HTTPValidationError? __value_422 = null;
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

                throw new global::AI21.ApiException<global::AI21.HTTPValidationError>(
                    message: __response.ReasonPhrase ?? string.Empty,
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
                var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                return
                    global::AI21.Plan.FromJson(__content, JsonSerializerContext) ??
                    throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                }
                catch (global::System.Net.Http.HttpRequestException __ex)
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

                using var __content = await __response.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);

                return
                    await global::AI21.Plan.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }

        /// <summary>
        /// Modify Plan
        /// </summary>
        /// <param name="assistantId"></param>
        /// <param name="planId"></param>
        /// <param name="code"></param>
        /// <param name="schemas"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.Plan> ModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchAsync(
            string assistantId,
            string planId,
            string code,
            global::System.Collections.Generic.IList<object>? schemas = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AI21.CreatePlanPayload
            {
                Code = code,
                Schemas = schemas,
            };

            return await ModifyPlanStudioV1AssistantsAssistantIdPlansPlanIdPatchAsync(
                assistantId: assistantId,
                planId: planId,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}