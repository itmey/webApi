using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using TerenWebApi.Models;
using TerenWebApi.ViewModels;

namespace TerenWebApi.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ConnectionStrings con;
        private readonly JWTConfiguration configuration;

        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="c">Connection string</param>
        /// <param name="configuration">Model konfiguracji</param>
        public AuthController(ConnectionStrings c, JWTConfiguration configuration)
        {
            con = c;
            this.configuration = configuration;
        }

        /// <summary>
        /// Generuje token JWT
        /// </summary>
        /// <param name="access">Dane dostępowe</param>
        /// <returns>Token JWT</returns>
        [HttpPost]
        [Route("token")]
        public AccessToken GenerateToken([FromBody]AccessVM access)
        {
            User user;
            using (var c = new SqlConnection(con.GetConnectionString()))
            {
                user = c.QueryFirstOrDefault<User>(Sql.GetUserByIndentity, access, commandTimeout: 3000);
            }

            if (user == null)
            {
                Response.StatusCode = StatusCodes.Status401Unauthorized;
                return new AccessToken { Success = false };
            }


            var claims = new[]
            {
                new Claim("Id", user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var key = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(configuration.SecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var expiredOn = DateTime.Now.AddMinutes(configuration.TokenExpirationTime);
            var token = new JwtSecurityToken(configuration.ValidIssuer,
                  configuration.ValidAudience,
                  claims,
                  expires: expiredOn,
                  signingCredentials: creds);


            using (var c = new SqlConnection(con.GetConnectionString()))
            {
                c.Execute(Sql.AddJwt, new { UserId = user.Id, Token = new JwtSecurityTokenHandler().WriteToken(token), ExpirationDate = expiredOn }, commandTimeout: 3000);
            }

            return new AccessToken
            {
                ExpireOnDate = token.ValidTo,
                Success = true,
                ExpiryIn = configuration.TokenExpirationTime,
                Token = new JwtSecurityTokenHandler().WriteToken(token)
            };
        }
    }
}