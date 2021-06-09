using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDataAuto
{
    interface IHeavyAuto:IAuto
    {
        public int CountSeat { get; }
        public bool Dizel { get;  }
    }
}
