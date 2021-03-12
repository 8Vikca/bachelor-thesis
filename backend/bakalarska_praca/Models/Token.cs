using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    public class Token
    {
        [JsonProperty("token")]
        public string TokenJWT { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }
    }
}

