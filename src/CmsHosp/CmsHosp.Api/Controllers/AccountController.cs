using CmsHosp.Api.Models;
using CmsHosp.Data;
using CmsHosp.Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace CmsHosp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _appDbContext;

        public AccountController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterRequest request)
        {
            if (_appDbContext.Users.Any(u => u.Email == request.Email))
            {
                return BadRequest("Bu emaile ait bir kullanıcı bulunmaktadır.");
            }

            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var user = new UserEntity
            {
                Name = request.Name,
                LastName = request.LastName,
                Email = request.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                VerificationToken = CreateRandomToken()
            };

            _appDbContext.Users.Add(user);
            await _appDbContext.SaveChangesAsync();

            return Ok("Kullanıcı başarılı bir şekilde kayıt oldu.");

        }

        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
