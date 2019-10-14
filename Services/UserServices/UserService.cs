using System;

namespace UserServices
{
    public static class UserService
    {
        public static Guid GenerateUserIds()
        {
            return Guid.NewGuid();
        }
    }
}