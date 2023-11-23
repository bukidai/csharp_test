namespace csharp_test
{
    /// <summary>
    /// トラックを表すクラス
    /// </summary>
    public class Truck : Car
    {
        public Truck() : base("いすゞ", 1200, 80)
        {
        }

        public override void Run()
        {
            ShowInfo();
            System.Console.WriteLine("Track is running");
        }
    }
}
