using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TerenWebApi.Interfaces;

namespace TerenWebApi.Models
{
    public class Log : ILog
    {
        private readonly ConnectionStrings con;
        /// <summary>
        /// Exception
        /// </summary>
        public Exception StackTrace;
        /// <summary>
        /// Dodatkowe informacje
        /// </summary>
        public string AdditionalInfo;
        /// <summary>
        /// Dodatkowe informacje
        /// </summary>
        public int UserId;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="ex"></param>
        /// <param name="addInfo"></param>
        public Log(ConnectionStrings con, Exception ex, string addInfo, int userId)
        {
            this.con = con;
            StackTrace = ex;
            AdditionalInfo = addInfo;
            UserId = userId;
        }

        /// <summary>
        /// Dodaj wpis do DB
        /// </summary>
        public void Send()
        {
            using (var c = new SqlConnection(con.GetConnectionString()))
            {
                c.Execute(Sql.AddErrorLog, this, commandTimeout: 3000);
            }
        }
    }
}
