using System;
using System.Collections.Generic;
using System.Text;

namespace MasterDataAuto.Interface.Light
{
    public class Suv : ILightAuto
    {
        public int Weight { get; private set; }
        
        public float CurrentSpeed { get;private set; }
        public string VinNumber { get; private set; }
        public string CurrentKey {get; private set; }
        public bool Stair => true;
        
        private bool _fullDrive = false;
        public int Wheels => 4;

        public Suv()
        {
            Random rand = new Random();
            Weight = rand.Next(2000, 3200);
            CurrentSpeed = 0;
            CallToFactory call1 = new CallToFactory();
            CurrentKey = call1.GenerateKeyNumber();


            CallToGoverment call = new CallToGoverment();
            VinNumber = call.GenerateVinNumber();
        }
        

        public void FullWheelDrive()
        {
            if (_fullDrive == false)
            {
                _fullDrive = true;
                Console.WriteLine("Подключили полный привод");
            }
            else
            {
                _fullDrive = false;
                Console.WriteLine("Отключили полный привод");
            }
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
    }
}
