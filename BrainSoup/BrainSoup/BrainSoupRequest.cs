using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
        
        
        public  string LoginPostRequest(string url,string email,string password)
        {

            try
            {
               
                ASCIIEncoding encoding = new ASCIIEncoding();
                string text = "email=" + email + "&password=" + password;
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
                return "Hata";
            }
        }
    }
}
