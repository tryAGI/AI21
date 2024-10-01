
#nullable enable

namespace AI21
{
    public partial class LibraryManagementClient
    {
        partial void PrepareV1LibraryManagementArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? name,
            ref string? path,
            ref global::AI21.FileStatus? status,
            global::System.Collections.Generic.IList<string>? label,
            ref int? limit,
            ref int? offset);
        partial void PrepareV1LibraryManagementRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? name,
            string? path,
            global::AI21.FileStatus? status,
            global::System.Collections.Generic.IList<string>? label,
            int? limit,
            int? offset);
        partial void ProcessV1LibraryManagementResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1LibraryManagementResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Get Organization Files<br/>
        /// Get metadata about a specific file by file ID. The file ID is generated by<br/>
        /// AI21 when you upload the file.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="path"></param>
        /// <param name="status">
        /// An enumeration.
        /// </param>
        /// <param name="label"></param>
        /// <param name="limit">
        /// Default Value: 1000
        /// </param>
        /// <param name="offset"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::AI21.FileResponse>> V1LibraryManagementAsync(
            string? name = default,
            string? path = default,
            global::AI21.FileStatus? status = default,
            global::System.Collections.Generic.IList<string>? label = default,
            int? limit = 1000,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: _httpClient);
            PrepareV1LibraryManagementArguments(
                httpClient: _httpClient,
                name: ref name,
                path: ref path,
                status: ref status,
                label: label,
                limit: ref limit,
                offset: ref offset);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/library/files",
                baseUri: _httpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("name", name) 
                .AddOptionalParameter("path", path) 
                .AddOptionalParameter("status", status?.ToValueString()) 
                .AddOptionalParameter("label", label, delimiter: ",", explode: true) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));

            foreach (var _authorization in _authorizations)
            {
                if (_authorization.Type == "Http" ||
                    _authorization.Type == "OAuth2")
                {
                    httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: _authorization.Name,
                        parameter: _authorization.Value);
                }
                else if (_authorization.Type == "ApiKey" &&
                         _authorization.Location == "Header")
                {
                    httpRequest.Headers.Add(_authorization.Name, _authorization.Value);
                }
            }

            PrepareRequest(
                client: _httpClient,
                request: httpRequest);
            PrepareV1LibraryManagementRequest(
                httpClient: _httpClient,
                httpRequestMessage: httpRequest,
                name: name,
                path: path,
                status: status,
                label: label,
                limit: limit,
                offset: offset);

            using var response = await _httpClient.SendAsync(
                request: httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: _httpClient,
                response: response);
            ProcessV1LibraryManagementResponse(
                httpClient: _httpClient,
                httpResponseMessage: response);

            var __content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: _httpClient,
                response: response,
                content: ref __content);
            ProcessV1LibraryManagementResponseContent(
                httpClient: _httpClient,
                httpResponseMessage: response,
                content: ref __content);

            try
            {
                response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException ex)
            {
                throw new global::System.InvalidOperationException(__content, ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::AI21.FileResponse>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::AI21.FileResponse> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}