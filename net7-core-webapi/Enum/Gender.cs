using System.Text.Json.Serialization;

namespace net7_core_webapi.Enum
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Gender
    {
        Nam = 1,
        Nu = 2
    }
}