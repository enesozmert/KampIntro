using System;
using System.Collections.Generic;
using System.Text;

namespace GameHomework.Entity
{
    public interface IEDevlet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TCKN { get; set; }
    }
}
