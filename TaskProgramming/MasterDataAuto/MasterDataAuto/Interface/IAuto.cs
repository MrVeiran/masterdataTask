using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDataAuto
{
    interface IAuto
    {
        public int Weight { get;  }
        public float CurrentSpeed { get; }
        public string VinNumber { get; }
        void UpSpeed(float speed);
        void StopSpeed(float speed);
        

    }
}
