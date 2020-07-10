using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PruebaBertoni.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web;

namespace PruebaBertoni.Data
{
    public class DataJson
    {
        public static object GetData(string route)
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create(route);
                var response = request.GetResponse();
                var jsonSerializer = new System.Web.Script.Serialization.JavaScriptSerializer();

                using (Stream responseStream = response.GetResponseStream())
                {
                    var reader = new StreamReader(responseStream, System.Text.Encoding.UTF8);
                    return JsonConvert.DeserializeObject(reader.ReadToEnd());
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}