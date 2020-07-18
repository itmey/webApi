using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TerenWebApi.Interfaces
{
    interface IDynamicParameters
    {
        DynamicParameters GetParam();
    }
}
