using GameHomework.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Reposity
{
    class UserReposity
    {
        public List<IUser> _users = new List<IUser>() { };
        public User _user = new User() { Id = 1, Name = "Enes", SurName = "Ozmert", TCKN = "11111111", DateOfbirth = "12.12.12", Password = "OSMANLI" };
        public User _user1 = new User() { Id = 2, Name = "Ahmet", SurName = "Ozmert", TCKN = "11111111", DateOfbirth = "12.12.12", Password = "OSMANLI" };
        public User _user2 = new User() { Id = 3, Name = "Mehmet", SurName = "Ozmert", TCKN = "11111111", DateOfbirth = "12.12.12", Password = "OSMANLI" };
    }
}
