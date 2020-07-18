using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerenWebApi.Models
{
    /// <summary>
    /// Model użytkowników
    /// </summary>
    public class User
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nazwa
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Nazwa
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Login
        /// </summary>
        public string Login { get; set; }
    }
}

