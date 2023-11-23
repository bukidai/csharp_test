namespace csharp_test
{
    public class App
    {
        public static void Main(string[] args)
        {
            Car[] cars = new Car[2];
            cars[0] = new PassengerCar("トヨタ", 2000, 180);
            cars[1] = new Truck();
            foreach (Car car in cars)
            {
                car.Run();
            }
        }
    }
}
