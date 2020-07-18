using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerenWebApi.Interfaces;

namespace TerenWebApi.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Imei { get; set; }
        public string Sn { get; set; }
        public DateTime ActivateDate { get; set; }
        public DateTime DeactivateDate { get; set; }
        public int UserId { get; set; }
    }
}
