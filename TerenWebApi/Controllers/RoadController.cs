using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TerenWebApi.Models;
using TerenWebApi.ViewModels;

namespace TerenWebApi.Controllers
{
    [Route("api/road")]
    [ApiController]
    public class RoadController : ControllerBase
    {
        private readonly ConnectionStrings con;

        public RoadController(ConnectionStrings c, JWTConfiguration configuration)
        {
            con = c;
        }

        /// <summary>
        /// Zwraca listę tras. Wymaga autoryzacji.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("list")]
        public List<Road> GetRoadList()
        {
            var jwt = HttpContext.User;
            //var prinicpal = (ClaimsPrincipal)Thread.CurrentPrincipal;

            var userId = jwt.Claims.Where(c => c.Type == "Id").Select(c => c.Value).SingleOrDefault();

            List<Road> roads = new List<Road>();

            using (var c = new SqlConnection(con.GetConnectionString()))
            {
                //roads = c.Query<List<Road>>(Sql.GetUserByIndentity/*.GetParam()*/, commandTimeout: 3000);
            }

            return roads;
        }
    }
}