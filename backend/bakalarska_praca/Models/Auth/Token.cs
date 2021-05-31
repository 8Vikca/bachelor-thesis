using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bakalarska_praca.Models
{
    /// <summary>Class <c>Token</c> models JSON tokens </summary>
    public class Token          //JSON token
    {
        [JsonProperty("token")]
        public string AccessToken { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }
    }
}

