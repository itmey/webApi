using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Threading.Tasks;

namespace TerenWebApi.Enums
{
    /// <summary>
    /// Klasa reprezentująca typu wyliczalne
    /// </summary>
    public class Enums
    {
        /// <summary>
        /// Kody akcji
        /// </summary>
        public enum ActionCode
        {
            /// <summary>
            /// Brak
            /// </summary>
            None = 0,
            /// <summary>
            /// Zalogowanie
            /// </summary>
            SignIn = 1,
            /// <summary>
            /// Załadowanie spraw
            /// </summary>
            LoadCases = 2,
            /// <summary>
            /// Zameldowanie pod adresem
            /// </summary>
            CheckIn = 3,
            /// <summary>
            /// Wysyłka raportu
            /// </summary>
            SendReport = 4,
            /// <summary>
            /// Wylogowanie z aplikacji
            /// </summary>
            Logout = 5

        }
    }
}
