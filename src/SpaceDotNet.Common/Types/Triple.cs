using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using JetBrains.Annotations;

namespace SpaceDotNet.Common.Types
{
    [PublicAPI]
    public class Triple<TFirst, TSecond, TThird>
    {
        [Required]
        [JsonPropertyName("first")]
        public TFirst First { get; set; }

        [Required]
        [JsonPropertyName("second")]
        public TSecond Second { get; set; }

        [Required]
        [JsonPropertyName("third")]
        public TThird Third { get; set; }
    }
}