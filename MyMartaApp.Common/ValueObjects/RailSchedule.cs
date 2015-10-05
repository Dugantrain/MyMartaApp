using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyMartaApp.Common.ValueObjects
{
    public class RailSchedule : IValueObject
    {
        [JsonProperty("DESTINATION")]
        public string Destination { get; set; }
        [JsonProperty("DIRECTION")]
        public string Direction { get; set; }
        [JsonProperty("EVENT_TIME")]
        public string EventTime { get; set; }
        [JsonProperty("LINE")]
        public string Line { get; set; }
        [JsonProperty("NEXT_ARR")]
        public DateTime NextArrival { get; set; }
        [JsonProperty("STATION")]
        public string Station { get; set; }
        [JsonProperty("TRAIN_ID")]
        public int TrainId { get; set; }
        [JsonProperty("WAITING_SECONDS")]
        public int WaitingSeconds { get; set; }
        [JsonProperty("WAITING_TIME")]
        public string WaitingTime { get; set; }
    }
}
