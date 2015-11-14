using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PastebinUploader
{
    public class Pastebin : IDisposable
    {
        private WebClient _wc;
        private readonly string DeveloperKey;

        public Pastebin(string key)
        {
            _wc = new WebClient();
            _wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";

            DeveloperKey = key;
        }

        public async Task<KeyValuePair<bool, string>> Authenticate(string user, string pass)
        {
            var postDataCollection = new NameValueCollection
            {
                { "api_dev_key", DeveloperKey},
                { "api_user_name", user},
                { "api_user_password", pass}
            };

            string postDataRaw = string.Concat(postDataCollection.AllKeys.Select(x => string.Format("{0}={1}&", x, postDataCollection[x])));

            var response = await _wc.UploadStringTaskAsync("http://pastebin.com/api/api_login.php", "POST", postDataRaw);

            return new KeyValuePair<bool, string>(!response.Contains("Bad API request"), response);
        }

        public async Task<string> CreatePaste(string pasteTitle, string pasteContent, string userKey = "")
        {
            var postDataCollection = new NameValueCollection
            {
                { "api_dev_key", DeveloperKey},
                { "api_option", "paste"},
                { "api_paste_name", pasteTitle},
                { "api_paste_code", pasteContent},
                { "api_user_key", userKey}
            };

            string postDataRaw = string.Concat(postDataCollection.AllKeys.Select(x => string.Format("{0}={1}&", x, postDataCollection[x])));

            var response = await _wc.UploadStringTaskAsync("http://pastebin.com/api/api_post.php", "POST", postDataRaw);
            return response;
        }

        public void Dispose()
        {
            _wc.Dispose();
        }
    }
}
