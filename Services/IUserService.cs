using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Services
{
        public interface IUserService
        {
            Task<bool> RegisterAsync(string username, string password);
            Task<bool> LoginAsync(string username, string password);
            Task<bool> VerifyUserAsync(string username, string password);
            Task<string> GetUserRoleAsync(string username);
        }



    public class UserService : IUserService
    {
        private readonly DBContext _context;

        public UserService(DBContext context)
        {
            _context = context;
        }

        public async Task<bool> RegisterAsync(string username, string password, string role)
        {
            try
            {
                var user = new User
                {
                    Username = username
                };

                // You should implement password hashing before storing it in database
                user.PasswordHash = password; // For demonstration only, replace with hashed password

                _context.Users.Add(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                // Handle exception appropriately, e.g., log the error
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public async Task<bool> LoginAsync(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
                return false;

            // Replace with actual password verification logic
            return user.PasswordHash == password; // For demonstration only, replace with hashed password comparison
        }

        public async Task<bool> VerifyUserAsync(string username, string password)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);

            if (user == null)
                return false;

            // Replace with actual password verification logic
            return user.PasswordHash == password; // For demonstration only, replace with hashed password comparison
        }

        public async Task<string> GetUserRoleAsync(string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username == username);
            return user?.Role;
        }

        public Task<bool> RegisterAsync(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}