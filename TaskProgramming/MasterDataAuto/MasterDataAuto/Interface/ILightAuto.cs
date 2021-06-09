using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDataAuto
{
    interface ILightAuto:IAuto
    {
        public int Wheels{ get; }
        public string  CurrentKey { get; }
        void KeyAccess(string key);
    }
}
