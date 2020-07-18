using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerenWebApi.Models
{
    /// <summary>
    /// Model ConnectionString
    /// </summary>
    public class ConnectionStrings
    {
        /// <summary>
        /// Mssql
        /// </summary>
        public string TST { get; set; }
        public string PROD { get; set; }

        public string GetConnectionString()
        {
            return TST;
        }
    }
}
