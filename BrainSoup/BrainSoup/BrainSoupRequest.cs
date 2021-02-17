using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrainSoup
{
    public class LoginResponse
    {public class Users
        {
            public string name { get; set; }
            public string email { get; set; }
            public string key { get; set; }
        }
        public IList<Users> LoginParser { get; set; }
    }
    class BrainSoupRequest
    {
        public string SendImage(string url, string image)
        {

            try
            {

                string path = image;
                FileInfo fi = new FileInfo(path);
                string fileName = fi.Name;
                byte[] fileContents = File.ReadAllBytes(fi.FullName);

                Uri webService = new Uri(url);
                HttpRequestMessage requestMessage = new HttpRequestMessage(HttpMethod.Post, webService);
                requestMessage.Headers.ExpectContinue = false;

                MultipartFormDataContent multiPartContent = new MultipartFormDataContent("----MyGreatBoundary");
                ByteArrayContent byteArrayContent = new ByteArrayContent(fileContents);
                byteArrayContent.Headers.Add("Content-Type", "multipart/form-data");
                multiPartContent.Add(byteArrayContent, "file", fileName);
                requestMessage.Content = multiPartContent;

                HttpClient httpClient = new HttpClient();
                Task<HttpResponseMessage> httpRequest = httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseContentRead, CancellationToken.None);
                HttpResponseMessage httpResponse = httpRequest.Result;

                HttpStatusCode statusCode = httpResponse.StatusCode;
                HttpContent responseContent = httpResponse.Content;
                string json = null;

                if (responseContent != null)
                {
                    Task<String> stringContentsTask = responseContent.ReadAsStringAsync();
                    json = stringContentsTask.Result;
                }

                return json;
            }
            catch
            {
                Style.Error("Resim Yüklenemedi");
                return "Hata";
            }
        }

        public  string Log(string url,string email,string image)
        {

            try
            {
               
                ASCIIEncoding encoding = new ASCIIEncoding();
                string text = "email=" + email + "&image=" + image;
                byte[] data = encoding.GetBytes(text);
                WebRequest request = WebRequest.Create(url);
                request.Credentials = CredentialCache.DefaultCredentials;
                request.Method = "POST";
                request.ContentLength = data.Length;
                request.ContentType = "application/x-www-form-urlencoded";
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(data, 0, data.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(dataStream);
                string myResponse=sr.ReadToEnd().Trim();
               
                sr.Close();
                dataStream.Close();
                return myResponse;

            }
            catch
            {
                Style.Error("Resim Yüklenemedi");
                return "Hata";
            }
        }
    }
}
