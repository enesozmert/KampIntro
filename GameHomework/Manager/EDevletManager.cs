using System;
using System.Collections.Generic;
using System.Text;
using GameHomework.Entity;
using GameHomework.IManager;
namespace GameHomework.Manager
{
    class EDevletManager : IEDevletManager
    {
        public void Control(User user, EDevlet eDevlet)
        {
            if (user.Name == eDevlet.Name && user.TCKN == eDevlet.TCKN)
            {
                Console.WriteLine("Onaylı kullanıcı : {0}",user.Name);
            }
        }
    }
}
