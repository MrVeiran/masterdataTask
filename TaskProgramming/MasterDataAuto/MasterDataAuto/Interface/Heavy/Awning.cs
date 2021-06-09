using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDataAuto.Interface.Heavy
{
    public class Awning : IHeavyAuto
    {
        public int Weight { get; private set; }

        public float CurrentSpeed { get; private set; }
        public string VinNumber { get; private set; }
        public int CountSeat => 2;

        public bool Coupler => true;
        public bool Dizel => true;

        public Awning()
        {
            Random rand = new Random();
            Weight = rand.Next(4000, 8000);
            CurrentSpeed = 0;
            CallToGoverment call = new CallToGoverment();
            VinNumber = call.GenerateVinNumber();
        }


        public void StopSpeed(float speed)
        {
            if(speed>0)
            CurrentSpeed -= speed;
        }

        public void UpSpeed(float speed)
        {
            CurrentSpeed += speed;
        }
    }
}
