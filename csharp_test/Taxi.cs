using System;

namespace csharp_test
{
    /// <summary>
    /// タクシークラス
    /// </summary>
    internal class Taxi : Car
    {
        public int Fare { get; set; }
        public int Fee { get; set; }

        public Taxi(int fare, int fee, int speed, string name) : base(name, 1200, speed)
        {
            Fare = fare;
            Fee = fee;
        }

        public override void Run()
        {
            Console.WriteLine("タクシーが走ります");
        }
    }
}
