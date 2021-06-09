using MasterDataAuto.Interface.Heavy;
using MasterDataAuto.Interface.Light;
using System;
using System.Threading;

namespace MasterDataAuto
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Suv suv = new Suv();
            Sedan sedan = new Sedan();
            Universal vers = new Universal();
            Van van = new Van();
            Awning awn = new Awning();
            
            Console.WriteLine($"Родной ключ {suv.CurrentKey} для машины {suv.GetType().Name}");
            Thread.Sleep(2000);
            Console.WriteLine($"Используем родной брелок для машины {suv.GetType().Name}");
            suv.KeyAccess(suv.CurrentKey);
            Thread.Sleep(2000);
            Console.WriteLine($"Используем чужой (asd) брелок для машины {suv.GetType().Name}");
            suv.KeyAccess("asd");
            Thread.Sleep(2000);
            
            suv.FullWheelDrive();
            suv.FullWheelDrive();
            Thread.Sleep(2000);

            int temp1=0;
            int temp2=12;
            Console.WriteLine("Сейчас будет разгон до 13, затем сбросим скорость до нуля, а затем будет разгоняться до 60 ");
            Thread.Sleep(2000);
            while (van.CurrentSpeed<60)
            {
                
                if (temp1 == 0)
                {
                    if (temp2 >= 0)
                    {
                        van.UpSpeed(1f);
                        temp2--;
                    }
                    else
                    {
                        temp1 = 1;
                    }
                   
                }

                if (temp1 == 1)
                {
                    if (van.CurrentSpeed != 0)
                    {

                        van.StopSpeed(1f);
                    }
                    else
                        temp1 = 2;
                }
                if (temp1 == 2)
                    van.UpSpeed(1f);

                Console.WriteLine($" Текущая скорость равна : {van.CurrentSpeed} км/ч");
                Thread.Sleep(100);
            }
            Console.WriteLine("Успешно сделали тест");
            Console.ReadLine();

        }
    }
}
