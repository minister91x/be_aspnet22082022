using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static ClassLibrary1123.WebPost;

namespace ClassLibrary1123
{
    public static class ConfigCommon
    {
        public static string Domain_URL
        {
            get
            {
                var root_url = System.Configuration.ConfigurationManager.AppSettings["DOMAIN_URL"] == null ? "http://localhost:51227" :
                    System.Configuration.ConfigurationManager.AppSettings["DOMAIN_URL"].ToString();
                return root_url;
            }

        }

        public static String ConvertToVietNammese(String sContent)
        {
            sContent = sContent.Trim().ToLower();
            var sUTF8Lower = "a|á|à|ả|ã|ạ|ă|ắ|ằ|ẳ|ẵ|ặ|â|ấ|ầ|ẩ|ẫ|ậ|đ|e|é|è|ẻ|ẽ|ẹ|ê|ế|ề|ể|ễ|ệ|i|í|ì|ỉ|ĩ|ị|o|ó|ò|ỏ|õ|ọ|ô|ố|ồ|ổ|ỗ|ộ|ơ|ớ|ờ|ở|ỡ|ợ|u|ú|ù|ủ|ũ|ụ|ư|ứ|ừ|ử|ữ|ự|y|ý|ỳ|ỷ|ỹ|ỵ";

            var sUCS2Lower = "a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|a|d|e|e|e|e|e|e|e|e|e|e|e|e|i|i|i|i|i|i|o|o|o|o|o|o|o|o|o|o|o|o|o|o|o|o|o|o|u|u|u|u|u|u|u|u|u|u|u|u|y|y|y|y|y|y";

            var aUTF8Lower = sUTF8Lower.Split(new[] { '|' });

            var aUCS2Lower = sUCS2Lower.Split(new[] { '|' });

            var l = aUTF8Lower.GetUpperBound(0);

            for (var i = 1; i < l; i++)
            {
                sContent = sContent.Replace(aUTF8Lower[i], aUCS2Lower[i]);
            }
            sContent = sContent.Replace(" ", "-");
            var list = new List<string> { "/", "?", "&", ":", "#", "*", "\"", "@", "%", "$", "!", "~" };
            sContent = list.Aggregate(sContent, (current, str) => current.Replace(str, "-"));

            const string filter = "-0123456789abcdefghijklmnopqrstuvwxyz";
            var s = "";
            l = sContent.Length;
            for (var i = 0; i < l; i++)
            {
                if (filter.IndexOf(sContent[i]) >= 0)
                {
                    s = s + sContent[i];
                }
            }

            return s;
        }

        public static string SendPost(string postData, string url)
        {
            bool success = false;
            string resp;
            System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            byte[] data = encoding.GetBytes(postData);

            System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate (object sender, X509Certificate certificate, X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; };
            System.Net.ServicePointManager.Expect100Continue = false;
            // Gan tap hop cac security protocal se ho tro ( ssl3, tsl, tsl11, tsl 12) . Toan tu | tra ra mot enum 
            // Neu khong gan mac dinh se chi co SSL3, TSL (voi framswork 4.5)
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;

            CookieContainer cookie = new CookieContainer();
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "POST";
            myRequest.ContentLength = data.Length;
            myRequest.ContentType = "application/x-www-form-urlencoded";
            myRequest.KeepAlive = false;
            myRequest.CookieContainer = cookie;

            myRequest.AllowAutoRedirect = false;

            using (Stream requestStream = myRequest.GetRequestStream())
            {
                requestStream.Write(data, 0, data.Length);
            }


            string responseXml = string.Empty;
            try
            {
                using (HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse())
                {
                    if (myResponse.StatusCode != HttpStatusCode.OK)
                        success = false;
                    else
                        success = true;
                    using (Stream respStream = myResponse.GetResponseStream())
                    {
                        using (StreamReader respReader = new StreamReader(respStream))
                        {
                            responseXml = respReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException webEx)
            {
                if (webEx.Response != null)
                {
                    using (HttpWebResponse exResponse = (HttpWebResponse)webEx.Response)
                    {
                        using (StreamReader sr = new StreamReader(exResponse.GetResponseStream()))
                        {
                            responseXml = sr.ReadToEnd();
                        }
                    }
                }
            }



            if (success)
            {
                resp = responseXml;
            }
            else
            {
                resp = responseXml;

            }

          
            return resp;
        }

        public static string SendGet(string url)
        {
            string response = string.Empty;
            try
            {
                System.Net.ServicePointManager.CertificatePolicy = new TrustAllCertificatePolicy();
                HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);

                myRequest.Method = "GET";
                //myRequest.ContentLength = data.Length;
                myRequest.CookieContainer = new CookieContainer();
                //myRequest.ContentType = "application/x-www-form-urlencoded";
                myRequest.ContentType = "application/json; charset=UTF-8";
                myRequest.KeepAlive = false;

                using (HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse())
                {
                    using (var reader = new StreamReader(myResponse.GetResponseStream()))
                    {
                        if (reader != null)
                        {
                            response = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                // Graph API Errors or general web exceptions 

                response = ex.Message;

            }
            catch (Exception)
            { }

            return response;
        }

    }
}
