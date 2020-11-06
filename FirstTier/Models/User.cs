﻿using System.Text.Json;
using System.Text.Json.Serialization;

namespace FirstTier.Models
{
    public class User
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        
        [JsonPropertyName("password")]
        public string Password { get; set; }
        
        [JsonPropertyName("id")]
        public int ID { get; set; }
        
        [JsonPropertyName("securitylevel")]
        public int SecurityLevel { get; set; }
        
        public override string ToString() {
            return JsonSerializer.Serialize(this);
        }
    }
}