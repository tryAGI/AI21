
#nullable enable

namespace AI21
{
    public partial class LibraryManagementClient
    {
        partial void PrepareV1LibraryManagementArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref int? requestStartTime,
            ref string? name,
            ref string? path,
            ref global::AI21.FileStatus? status,
            global::System.Collections.Generic.IList<string>? label,
            ref int? limit,
            ref int? offset);
        partial void PrepareV1LibraryManagementRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            int? requestStartTime,
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
        /// <param name="requestStartTime">
        /// Default Value: 1730898830008
        /// </param>
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
            int? requestStartTime = default,
            string? name = default,
            string? path = default,
            global::AI21.FileStatus? status = default,
            global::System.Collections.Generic.IList<string>? label = default,
            int? limit = default,
            int? offset = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareV1LibraryManagementArguments(
                httpClient: HttpClient,
                requestStartTime: ref requestStartTime,
                name: ref name,
                path: ref path,
                status: ref status,
                label: label,
                limit: ref limit,
                offset: ref offset);

            var __pathBuilder = new PathBuilder(
                path: "/studio/v1/library/files",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("request_start_time", requestStartTime?.ToString()) 
                .AddOptionalParameter("name", name) 
                .AddOptionalParameter("path", path) 
                .AddOptionalParameter("status", status?.ToValueString()) 
                .AddOptionalParameter("label", label, delimiter: ",", explode: true) 
                .AddOptionalParameter("limit", limit?.ToString()) 
                .AddOptionalParameter("offset", offset?.ToString()) 
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
            PrepareV1LibraryManagementRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                requestStartTime: requestStartTime,
                name: name,
                path: path,
                status: status,
                label: label,
                limit: limit,
                offset: offset);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1LibraryManagementResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1LibraryManagementResponseContent(
                httpClient: HttpClient,
                httpResponseMessage: __response,
                content: ref __content);

            try
            {
                __response.EnsureSuccessStatusCode();
            }
            catch (global::System.Net.Http.HttpRequestException __ex)
            {
                throw new global::System.InvalidOperationException(__content, __ex);
            }

            return
                global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::AI21.FileResponse>), JsonSerializerContext) as global::System.Collections.Generic.IList<global::AI21.FileResponse> ??
                throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
        }
    }
}