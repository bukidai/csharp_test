using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test
{
    /// <summary>
    /// 自動車を表す抽象クラス
    /// </summary>
    public abstract class Car
    {
        public string Name { get; set; }
        public int Displacement { get; set; }
        public int MaxSpeed { get; set; }

        public Car(string name, int displacement, int maxSpeed)
        {
            Name = name;
            Displacement = displacement;
            MaxSpeed = maxSpeed;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}, Displacement: {1}, MaxSpeed: {2}", Name, Displacement, MaxSpeed);
        }

        public abstract void Run();
    }
}
