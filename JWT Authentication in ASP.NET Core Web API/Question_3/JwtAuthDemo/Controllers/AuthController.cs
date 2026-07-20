using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using JwtAuthDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace JwtAuthDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            if (IsValidUser(model))
            {
                var token = GenerateJwtToken(model.Username);
                return Ok(new { Token = token });
            }

            return Unauthorized();
        }

        // Demo-only credential check. Replace with a real user store
        // (database, identity provider, etc.) in production.
        private bool IsValidUser(LoginModel model)
        {
            return model.Username == "admin" && model.Password == "password";
        }

        private string GenerateJwtToken(string username)
        {
            // Demo-only: every logged-in user gets the "Admin" role so the
            // [Authorize(Roles = "Admin")] endpoint below is reachable.
            // In a real app, look up the user's actual roles from your
            // user store and add one Claim(ClaimTypes.Role, role) per role.
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin")
            };

            var key = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var durationMinutes = double.Parse(_configuration["Jwt:DurationInMinutes"] ?? "60");

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
                claims: claims,
                expires: DateTime.Now.AddMinutes(durationMinutes),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
