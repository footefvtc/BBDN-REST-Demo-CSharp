﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using BBDNRESTDemoCSharp;

namespace BBDNRESTDemoCSharp
{
    public class MembershipService : IRestService<Membership>, IDisposable
    {
        HttpClient client;
        String access_token;


        public MembershipService(Token token)
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.access_token);
            access_token = token.access_token;
        }

        
        public async Task<Membership> CreateObject(Membership newMembership)
        {
            Membership membership = new Membership();
            var uri = new Uri(Constants.HOSTNAME + Constants.COURSE_PATH + "/externalId:" + Constants.COURSE_ID + "users/externalId:" + Constants.USER_ID);

            try
            {
                var json = JsonConvert.SerializeObject(membership);
                var body = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(uri, body);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    membership = JsonConvert.DeserializeObject<Membership>(content);
                    Debug.WriteLine(@"				Membership successfully created.");
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return membership;
        }

        
        public async Task<Membership> ReadObject()
        {
            Membership membership = new Membership();

            var uri = new Uri(Constants.HOSTNAME + Constants.COURSE_PATH + "/externalId:" + Constants.COURSE_ID + "/users/externalId:" + Constants.USER_ID + "?expand=user");
            //var uri = new Uri(Constants.HOSTNAME + Constants.COURSE_PATH + "/" + Constants.COURSE_ID + "/users"); ///externalId:" + Constants.USER_ID);

            try
            {
                var response = await client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    membership = JsonConvert.DeserializeObject<Membership>(content); 
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }

            return membership;
        }

        
        public async Task<Membership> UpdateObject(Membership updateMembership)
        {
            Membership membership = new Membership();

            try
            {
                var s = new JsonSerializerSettings { DateFormatHandling = DateFormatHandling.MicrosoftDateFormat };

                var request = new HttpRequestMessage(new HttpMethod("PATCH"), Constants.HOSTNAME + Constants.COURSE_PATH + "/externalId:" + Constants.COURSE_ID + "users/externalId:" + Constants.USER_ID);
                var json = JsonConvert.SerializeObject(updateMembership);

                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", access_token);
                request.Content = new StringContent(json, System.Text.Encoding.UTF8, "application/json;odata=verbose");


                HttpResponseMessage response = await client.SendAsync(request);


                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"				Membership successfully updated.");
                    var content = await response.Content.ReadAsStringAsync();
                    membership = JsonConvert.DeserializeObject<Membership>(content);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
            return (membership);
        }

        public async Task<Membership> DeleteObject()
        {
            Membership membership = new Membership();
            var uri = new Uri(Constants.HOSTNAME + Constants.COURSE_PATH + "/externalId:" + Constants.COURSE_ID + "users/externalId:" + Constants.USER_ID);

            try
            {
                var response = await client.DeleteAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    Debug.WriteLine(@"				Membership successfully deleted.");
                    var content = await response.Content.ReadAsStringAsync();
                    membership = JsonConvert.DeserializeObject<Membership>(content);
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"				ERROR {0}", ex.Message);
            }
            return (membership);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                client.Dispose();

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~MembershipService() {
           // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
           Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion
    }
}

