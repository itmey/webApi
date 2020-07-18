using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerenWebApi.Models
{
    public class JWTConfiguration
    {
        /// <summary>
        /// SecretKey
        /// </summary>
        public string SecretKey { get; set; }
        /// <summary>
        /// ValidIssuer
        /// </summary>
        public string ValidIssuer { get; set; }
        /// <summary>
        /// ValidAudience
        /// </summary>
        public string ValidAudience { get; set; }
        /// <summary>
        /// TokenExpirationTime
        /// </summary>
        public int TokenExpirationTime { get; set; }
    }
}
