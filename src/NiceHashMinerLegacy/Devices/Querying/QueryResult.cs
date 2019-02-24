﻿namespace NiceHashMiner.Devices.Querying
{
    public class QueryResult
    {
        public bool FailedMinNVDriver { get; internal set; }
        public string MinDriverString { get; }
        public string RecommendedDriverString { get; }

        public bool FailedRecommendedNVDriver { get; internal set; }
        public string CurrentDriverString { get; internal set; }

        public bool NoDevices { get; internal set; }
        public bool FailedRamCheck { get; internal set; }

        public bool FailedVidControllerStatus { get; internal set; }
        public string FailedVidControllerInfo { get; internal set; }

        public QueryResult(string minDriverString, string recDriverString)
        {
            MinDriverString = minDriverString;
            RecommendedDriverString = recDriverString;
        }
    }
}
