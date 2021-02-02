using System.Collections.Generic;

namespace WinformEventsExample
{
    public class UserManager : IUserManager
    {
        private List<CommonUser> _users;

        public UserManager()
        {
            _users = new List<CommonUser>();
        }

        public void CreateUser(CommonUser user)
        {
            _users.Add(user);
        }
    }
}