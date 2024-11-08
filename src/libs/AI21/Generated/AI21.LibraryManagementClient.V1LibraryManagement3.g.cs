
#nullable enable

namespace AI21
{
    public partial class LibraryManagementClient
    {
        partial void PrepareV1LibraryManagement3Arguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.Guid fileId,
            ref int? requestStartTime,
            global::AI21.FilesUpdateRequest request);
        partial void PrepareV1LibraryManagement3Request(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.Guid fileId,
            int? requestStartTime,
            global::AI21.FilesUpdateRequest request);
        partial void ProcessV1LibraryManagement3Response(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessV1LibraryManagement3ResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Update File<br/>
        /// Update the specified parameters of a specific document in the user's library.<br/>
        /// This operation currently supports updating the publicUrl and labels parameters.<br/>
        /// &gt; **This operation overwrites the specified items with the new data you provide.**<br/>
        /// &gt; If you wish to add new labels to the labels list without removing the existing ones,<br/>
        /// &gt; you must submit a labels list that includes both the current and new labels.**<br/>
        /// &gt;<br/>
        /// &gt; For instance, if the current labels are "Label A" and "Label B", and you wish to<br/>
        /// &gt; add "New Label C" and "New Label D" to the list, you must specify `"labels": ["Label A", "Label B", "New Label C", "New Label D"]`.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898970831
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1LibraryManagement3Async(
            global::System.Guid fileId,
            global::AI21.FilesUpdateRequest request,
            int? requestStartTime = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareV1LibraryManagement3Arguments(
                httpClient: HttpClient,
                fileId: ref fileId,
                requestStartTime: ref requestStartTime,
                request: request);

            var __pathBuilder = new PathBuilder(
                path: $"/studio/v1/library/files/{fileId}",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder 
                .AddOptionalParameter("request_start_time", requestStartTime?.ToString()) 
                ; 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Put,
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
            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
            var __httpRequestContent = new global::System.Net.Http.StringContent(
                content: __httpRequestContentBody,
                encoding: global::System.Text.Encoding.UTF8,
                mediaType: "application/json");
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareV1LibraryManagement3Request(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                fileId: fileId,
                requestStartTime: requestStartTime,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessV1LibraryManagement3Response(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            var __content = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

            ProcessResponseContent(
                client: HttpClient,
                response: __response,
                content: ref __content);
            ProcessV1LibraryManagement3ResponseContent(
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

            return __content;
        }

        /// <summary>
        /// Update File<br/>
        /// Update the specified parameters of a specific document in the user's library.<br/>
        /// This operation currently supports updating the publicUrl and labels parameters.<br/>
        /// &gt; **This operation overwrites the specified items with the new data you provide.**<br/>
        /// &gt; If you wish to add new labels to the labels list without removing the existing ones,<br/>
        /// &gt; you must submit a labels list that includes both the current and new labels.**<br/>
        /// &gt;<br/>
        /// &gt; For instance, if the current labels are "Label A" and "Label B", and you wish to<br/>
        /// &gt; add "New Label C" and "New Label D" to the list, you must specify `"labels": ["Label A", "Label B", "New Label C", "New Label D"]`.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestStartTime">
        /// Default Value: 1730898970831
        /// </param>
        /// <param name="publicUrl">
        /// The public URL of the file, if any. This URL is not validated by<br/>
        /// AI21 or used in any way. It is strictly a piece of metadata that you can<br/>
        /// optionally attach to a file.
        /// </param>
        /// <param name="labels">
        /// Any labels to associate with this file. Separate multiple labels with commas. If<br/>
        /// provided, will overwrite all existing labels.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<string> V1LibraryManagement3Async(
            global::System.Guid fileId,
            int? requestStartTime = default,
            string? publicUrl = default,
            global::System.Collections.Generic.IList<string>? labels = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::AI21.FilesUpdateRequest
            {
                PublicUrl = publicUrl,
                Labels = labels,
            };

            return await V1LibraryManagement3Async(
                fileId: fileId,
                requestStartTime: requestStartTime,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}