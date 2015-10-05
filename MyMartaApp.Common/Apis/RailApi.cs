using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using MyMartaApp.Common.ValueObjects;
using Newtonsoft.Json;

namespace MyMartaApp.Common.Apis
{
	public interface IRailApi
	{
        IEnumerable<RailArrival> GetRailArrivals(string apiKey);
	}

	public class RailApi : IRailApi
	{
		public IEnumerable<RailArrival> GetRailArrivals(string apiKey)
		{
            var webRequest = 
                WebRequest.Create(
                    string.Format(
                        "http://developer.itsmarta.com/RealtimeTrain/RestServiceNextTrain/GetRealtimeArrivals?apikey={0}",
                        apiKey)
                    );
		    using (var response = webRequest.GetResponse())
		    {
                using (var stream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        var responseString = reader.ReadToEnd();
                        return JsonConvert.DeserializeObject<IEnumerable<RailArrival>>(responseString);
                    }
                }
		    }
		}
	}
}

