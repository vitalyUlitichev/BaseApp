using System.Collections.Generic;
using System.Linq;
using DataContext;
using DataModels;
using Microsoft.AspNetCore.Mvc;
using UserServices;
using UserViewModels;

namespace AuthService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly UserContext _context;
        private static readonly List<string> Names = new List<string>{"Vitaly", "Alexey", "Nikita"};

        public UsersController(UserContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<UserViewModel> GetAllUsers()
        {
            UserDataModel user = new UserDataModel {Name = "Tom", Age = 21, Id = UserService.GenerateUserIds()};

            _context.Users.Add(user);
            _context.SaveChanges();

            return Enumerable.Range(0, 3).Select(index => new UserViewModel(Names[index]))
                .ToArray();
        }
    }
}