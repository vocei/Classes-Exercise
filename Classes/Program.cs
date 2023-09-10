using System.Threading.Channels;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car newCar = new Car();
            newCar.Make = "Corvette";
            newCar.Model = "Stingray";
            newCar.Year = 1970;

            var toyota = new Car()
            {
               Make = "Toyota" ,
               Model = "Corolla" ,
               Year = 2016

             };

            var chevy = new Car("Chevy" , "Impala" , 2001);
            var carList = new List<Car>() {newCar, toyota, chevy,};

            foreach (var car in carList)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }



        }

    }
}
