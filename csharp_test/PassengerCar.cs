using System;

namespace csharp_test
{
    /// <summary>
    /// 乗用車を表すクラス
    /// </summary>
    public class PassengerCar : Car
    {
        public PassengerCar(string name, int displacement, int maxSpeed) : base(name, displacement, maxSpeed)
        {
        }

        public override void Run()
        {
            ShowInfo();
            Console.WriteLine("PassengerCar is running");
        }
    }
}
