﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StatisticsAnalysisTool.Models
{
    public class MarketStatResponse
    {
        [JsonProperty(PropertyName = "timestamps")]
        public List<ulong> TimeStamps { get; set; }

        [JsonProperty(PropertyName = "prices_min")]
        public List<ulong> PricesMin { get; set; }

        [JsonProperty(PropertyName = "prices_max")]
        public List<ulong> PricesMax { get; set; }

        [JsonProperty(PropertyName = "prices_avg")]
        public List<decimal> PricesAvg { get; set; }
    }

    public class MarketStatChartResponse
    {
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        [JsonProperty(PropertyName = "data")]
        public MarketStatResponse Data { get; set; }
    }

    public class MarketStatChartItem
    {
        public string UniqueName { get; set; }

        public List<MarketStatChartResponse> MarketStatChartResponse { get; set; }
        
        public DateTime LastUpdate { get; set; }
    }

}