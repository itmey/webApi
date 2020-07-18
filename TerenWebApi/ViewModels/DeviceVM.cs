using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TerenWebApi.Interfaces;

namespace TerenWebApi.ViewModels
{
    public class DeviceVM
    {
        public string Imei { get; set; }
        public string Sn { get; set; }

        public int UserId { get; set; }
    }
}
