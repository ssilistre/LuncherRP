using Newtonsoft.Json;
using System.Collections.Generic;

namespace fivemLuncher
{
    class jsonClass
    {
        [JsonProperty("liste")]
        public static IList<string> liste { get; set; }

        [JsonProperty("version")]
        public static string version { get; set; }

        [JsonProperty("ip")]
        public static object ip { get; set; }

        [JsonProperty("port")]
        public static object port { get; set; }

        [JsonProperty("guncellemelink")]
        public static string guncellemelink { get; set; }

        [JsonProperty("ts3")]
        public static string ts3 { get; set; }

        [JsonProperty("discord")]
        public static string discord { get; set; }

        [JsonProperty("avatarurl")]
        public static string avatarurl { get; set; }

        [JsonProperty("discordbot")]
        public static string discordbot { get; set; }

        [JsonProperty("discordrc")]
        public static string discordrc { get; set; }

        [JsonProperty("discordRCbuyukResim")]
        public static string discordRCbuyukResim { get; set; }

        [JsonProperty("discordRCkucukResim")]
        public static string discordRCkucukResim { get; set; }

        [JsonProperty("duyurular")]
        public static string duyurular { get; set; }
    }
}
