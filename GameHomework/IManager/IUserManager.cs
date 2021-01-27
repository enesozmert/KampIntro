using GameHomework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.IManager
{
    interface IUserManager
    {
        void Add(IUser user);
        void Update(IUser user);
        void Delete(IUser user);
        List<IUser> ToList();
    }
}
