
#nullable enable

namespace AI21
{
    public partial class Ai21Api
    {
        partial void PrepareGetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string organizationId,
            ref string dataSource,
            ref int? requestStartTime);
        partial void PrepareGetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string organizationId,
            string dataSource,
            int? requestStartTime);
        partial void ProcessGetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Data Source Status
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="dataSource"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898900272
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::AI21.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::AI21.ConnectorsStatus> GetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetAsync(
            string organizationId,
            string dataSource,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetArguments(
                httpClient: HttpClient,
                organizationId: ref organizationId,
                dataSource: ref dataSource,
                requestStartTime: ref requestStartTime);

            var __pathBuilder = new PathBuilder(
                path: $"/studio/v1/connectors/connected-users/{organizationId}/data-sources/{dataSource}/status",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("request_start_time", requestStartTime?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                organizationId: organizationId,
                dataSource: dataSource,
                requestStartTime: requestStartTime);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetResponse(
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
                ProcessGetDataSourceStatusStudioV1ConnectorsConnectedUsersOrganizationIdDataSourcesDataSourceStatusGetResponseContent(
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
                    global::AI21.ConnectorsStatus.FromJson(__content, JsonSerializerContext) ??
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
                    await global::AI21.ConnectorsStatus.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                    throw new global::System.InvalidOperationException("Response deserialization failed.");
            }
        }
    }
}