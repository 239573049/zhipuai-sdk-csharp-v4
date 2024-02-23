using System.Collections.Generic;
using System.Text.Json;

namespace ZhipuApi.Models.ResponseModels.EmbeddingModels
{
    public class EmbeddingResponseBase
    {
        public string model { set; get; }
        public string _object { set; get; }
        public Dictionary<string, int> usage { set; get; }
        public EmbeddingDataItem[] data { get; set; }
        public Dictionary<string, string> error { get; set; }
        
        public static EmbeddingResponseBase FromJson(string json)
        {
            return JsonSerializer.Deserialize<EmbeddingResponseBase>(json);
        }
    }
}