    using System.Runtime.InteropServices;

namespace Vecka_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ÖVNING 10 \n");
            dating();
            Console.WriteLine("\n\nÖVNING 11\n");
            vroomvroom();

        }
        #region Övning 10
        static void dating()
        {
            user gregger97 = new user();
            gregger97.first_name = "greger";
            gregger97.last_name = "leder";
            gregger97.hobby = "Cheap work force!";
            gregger97.age = 27;

            user arnealigator = new user();
            arnealigator.first_name = "arne";
            arnealigator.last_name = "aligator";
            arnealigator.hobby = "not to eat children";
            arnealigator.age = 30;

            Console.WriteLine(gregger97.introduction());
            Console.WriteLine(arnealigator.introduction());

        }

        class user
        {
            public string first_name;
            public string last_name;
            public string hobby;
            public int age;
            public string introduction()
            {
                string greating_p1 = "Hi, my name is " + first_name + " " + last_name + ".";
                string greating_p2 = " I am " + age + " years old and i like " + hobby;

                return greating_p1 + greating_p2;
            }
        }
        #endregion

        #region övning 11

        class car
        {
            public double current_fuel;   // the amount of fuel remaining
            public double fuel_capacity; // total capacity of the tank
            public double fuel_rate;    // x Liter per 100 km


            // how much fuel you can fuel before it's full 
            public double capacity()
            {   
                double capacity_left = (fuel_capacity - current_fuel);

                return capacity_left;
            }
            // how far you can drive on your current fuel
            public int distance()
            {
                double burn = current_fuel/fuel_rate;
                double distance = burn * 100;
                


                return (int)distance ;
            }
            // a function to write out a information msg
            public void informaation () 
            {
                Console.WriteLine("You can fuel around " + capacity() + " liters, ´before the tank is full");
                Console.WriteLine("On your current fuel, " + current_fuel + " liters, you can dirve " + distance() + "Km");
            }

        }
        // a callable function for this specific task
        static void vroomvroom()
        {
            car vroom = new car();
            vroom.fuel_capacity = 80;
            vroom.current_fuel = 23;
            vroom.fuel_rate = 5;


            vroom.informaation();
            
        }





        #endregion
    }

}