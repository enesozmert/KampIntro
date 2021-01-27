using GameHomework.Entity;
using GameHomework.IManager;
using GameHomework.Reposity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace GameHomework.Manager
{
    class UserManager : IUserManager
    {
        UserReposity _userReposity = new UserReposity();
        public void Add(IUser user)
        {
            _userReposity._users.Add(user);
            Console.WriteLine("Kullanıcı eklendi : " + user.Name);
        }

        public void Delete(IUser user)
        {
            _userReposity._users.Remove(user);
            Console.WriteLine("Kullanıcı silindi : " + user.Name);
        }

        public List<IUser> ToList()
        {
            return _userReposity._users.ToList();
        }

        public void Update(IUser user)
        {
            Console.WriteLine("Kullanıcı Update : " + user.Name);
        }
    }
}
