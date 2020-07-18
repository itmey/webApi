using Dapper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TerenWebApi.Interfaces;

namespace TerenWebApi.ViewModels
{
    public class AccessVM
    {
        /// <summary>
        /// Login
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Login { get; set; }

        /// <summary>
        /// Hasło
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Pin { get; set; }

        /// <summary>
        /// Imei urządzenia
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Imei { get; set; }

        /// <summary>
        /// SerialNumber urządzenia
        /// </summary>
        [Required]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Sn { get; set; }

        public AccessVM()
        {
        }

        public AccessVM(string login, string pin)
        {
            Login = login;
            Pin = pin;
        }
    }
}
