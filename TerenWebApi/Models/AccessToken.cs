using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerenWebApi.Models
{
    /// <summary>
    /// Model Tokenu dostępowego (JWT)
    /// </summary>
    public class AccessToken
    {
        /// <summary>
        /// Data wygaśnięcia
        /// </summary>
        public DateTime ExpireOnDate { get; set; }

        /// <summary>
        /// Wygaśnie za
        /// </summary>
        public long ExpiryIn { get; set; }

        /// <summary>
        /// Token
        /// </summary>
        public string Token { get; set; }

        /// <summary>
        /// Czy sukces?
        /// </summary>
        public bool Success { get; set; }
    }
}
