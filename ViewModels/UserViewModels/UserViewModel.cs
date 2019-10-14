using System;
using UserServices;

namespace UserViewModels
{
    public class UserViewModel
    {
        public Guid Id {get; set; }
        public string Name {get; set; }

        public UserViewModel(string name)
        {
            Id = UserService.GenerateUserIds();
            Name = name;
        }
    }
}