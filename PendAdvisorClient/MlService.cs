﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace PendAdvisorClient
{
   internal static class MlService
   {
      private const string ML_SERVICE_URL = "http://localhost:5050/api/Advice";
      private static readonly HttpClient _httpClient;

      static MlService()
      {
         _httpClient = new HttpClient();
         _httpClient.Timeout = TimeSpan.FromSeconds(5);  //default=100s
         _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
      }

      internal async static Task<string> ObtainPendAdviceAsync(string payload)
      {
         var request = new HttpRequestMessage
         {
            Method = HttpMethod.Post,
            RequestUri = new Uri(ML_SERVICE_URL),
            Content = new StringContent(payload)
         };
          request.Content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");
         HttpResponseMessage response;
         try
         {
            response = await _httpClient.SendAsync(request).ConfigureAwait(false);
         }
         catch //e.g. no service running, i.e. HttpRequestException: An error occurred while sending the request ---> WebException: Unable to connect to the remote server ---> SocketException: No connection could be made because the target machine actively refused it ...
         {
            return null;  ///TODO: add some diagnostics
         }
         if (response.IsSuccessStatusCode) return await response.Content.ReadAsStringAsync();
         return null;  ///TODO: add some diagnostics
      }

   }
}
