using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerenWebApi.Interfaces;
using static TerenWebApi.Enums.Enums;

namespace TerenWebApi.Models
{
    /// <summary>
    /// Obsługa logowania
    /// </summary>
    public class ActionLog : ILog
    {
        public ActionCode Code;
        public void Send()
        {
            throw new NotImplementedException();
        }
    }
}
