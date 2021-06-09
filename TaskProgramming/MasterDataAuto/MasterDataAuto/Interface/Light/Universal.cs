using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDataAuto.Interface.Light
{
    public class Universal : ILightAuto
    {
        public int Weight { get; private set; }

        public float CurrentSpeed { get; private set; }
        public string VinNumber { get; private set; }
        public string CurrentKey { get; private set; }

        private bool _seat = false;
        public int Wheels => 4;

        public Universal()
        {
            Random rand = new Random();
            Weight = rand.Next(1700, 2300);
            CurrentSpeed = 0;
            CallToFactory call1 = new CallToFactory();
            CurrentKey = call1.GenerateKeyNumber();


            CallToGoverment call = new CallToGoverment();
            VinNumber = call.GenerateVinNumber();
        }

        public void KeyAccess(string key)
        {
            if (CurrentKey == key)
                Console.WriteLine("Есть доступ");
            else
                Console.WriteLine("Доступ запрещен");
        }

        public void StopSpeed(float speed)
        {
            CurrentSpeed -= speed;
        }

        public void UpSpeed(float speed)
        {
            CurrentSpeed += speed;
        }
        public void FoldTheSeat()
        {
            if (_seat==false)
            {
                _seat = true;
                Console.WriteLine("Размер багажника увеличился");
                
            }
            else
            {
                _seat = false;
                Console.WriteLine("Багажник уменьшился");
            }
                
        }
    }
}
