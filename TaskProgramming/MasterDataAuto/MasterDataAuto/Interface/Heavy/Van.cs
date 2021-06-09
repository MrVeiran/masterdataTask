using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDataAuto.Interface.Heavy
{
    public class Van : IHeavyAuto
    {
        public int Weight { get; private set; }

        public float CurrentSpeed { get; private set; }
        public string VinNumber { get; private set; }
        public int CountSeat => 2;

        public bool Doorleft => true;
        public bool Dizel => true;

        public Van()
        {
            Random rand = new Random();
            Weight = rand.Next(3300, 4000);
            CurrentSpeed = 0;
            CallToGoverment call = new CallToGoverment();
            VinNumber = call.GenerateVinNumber();
        }


        public void StopSpeed(float speed)
        {
            if (CurrentSpeed > 0)
            
                CurrentSpeed -= speed;
            
        }

        public void UpSpeed(float speed)
        {
            CurrentSpeed += speed;
        }
    }
}
