using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Entity
{
    class User : IUser
    {
        public int Id { get ; set ; }
        public string Name { get ; set ; }
        public string SurName { get ; set ; }
        public string TCKN { get ; set ; }
        public string DateOfbirth { get ; set ; }
        public string Password { get ; set ; }
    }
}
