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
    public class Pastebin
    {
        public string DeveloperKey { get; set; }

        public Pastebin(string key)
        {
            DeveloperKey = key;
        }

        public async Task<string> CreatePaste(string pasteTitle, string pasteContent)
        {
            var postDataCollection = new NameValueCollection
            {
                {"api_dev_key", DeveloperKey},
                {"api_option", "paste"},
                {"api_paste_name", pasteTitle},
                {"api_paste_code", pasteContent}
            };

            string postDataRaw = string.Join("", postDataCollection.AllKeys.Select(x => string.Format("{0}={1}&", x, postDataCollection[x])));

            var request = (HttpWebRequest)WebRequest.Create(new Uri("http://pastebin.com/api/api_post.php"));
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            using (var writer = new StreamWriter(await request.GetRequestStreamAsync()))
                await writer.WriteAsync(postDataRaw);

            return await new StreamReader((await request.GetResponseAsync()).GetResponseStream()).ReadToEndAsync();
        }
    }
}
