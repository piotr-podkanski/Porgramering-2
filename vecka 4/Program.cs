namespace v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS8321 // these functions are supposed to be tested on recall
            #region övning 3
            static void numbers()
            {

                // creating an array of 5 numbers
                int[] numbers = { 1, 2, 3, 4, 5, };


                // printing out every number from the array

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine(numbers[i]);
                }

                // adding up every number

                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                Console.WriteLine(sum);


                for (int i = 0; i <= numbers.Length; i++)
                {
                    numbers[i] = numbers[i] * 2;

                    Console.WriteLine(numbers[i]);

                }
            }
            /////////ta bort "//"om du ska testa koden under//////////
            //numbers ();

            #endregion

            #region övning 4

            static void tickets()
            {

                double price = 200;

                int age = int.Parse(Console.ReadLine());

                //kid
                if (age < 5)
                {
                    price = 0;
                }
                //student
                else if (age < 20)
                {
                    price = price * 0.8;
                }

                // adult
                else if (age < 60)
                {

                }

                // senior

                else
                {
                    price = (price * 0.5);
                }

                Console.WriteLine(price);
            }



            //tickets();

            static void passwords()
            {

            }




            #endregion

            #region övning 5

            static void discounts()
            {
                // declaring variabels for the prograam
                #region variables 
                double price = 10;
                int age = 0;
                string if_student;
                string what_discount = "";
                #endregion

                Console.WriteLine("Hello, please input your age (use whole numbers)");
                // making a loop with try and catch incase the user writes in a value that is not allowed
                #region age
                while (true)
                {
                    try
                    {
                        age = int.Parse(Console.ReadLine());

                        if (age > 100 || age < 1)
                        {
                            Console.WriteLine("ditt ålder låter orimlig, försök igen");
                            continue;
                        }
                        break;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("you have to enter a whole number ");
                    }
                }
                #endregion

                // is the user a student?
                #region student?
                Console.WriteLine("Are you a student?");
                Console.WriteLine("y/n?");

                while (true)
                {
                    if_student = Console.ReadLine().ToLower();
                    string[] ans = { "y", "n" };
                    if (ans.Contains(if_student))
                    {
                        break;
                    }
                    else { Console.WriteLine("please anser with y/n"); }

                }
                #endregion

                // evaluating the price for the user
                #region price

                if (if_student == "y")
                {
                    price = price * 0.8;
                    what_discount = "the student ";
                }
                else
                {
                    if (age <= 18)
                    {
                        price = price * 0.9;
                        what_discount = "the teenager ";
                    }
                    else if (age >= 65)
                    {
                        price = price * 0.85;
                        what_discount = "the elderly ";
                    }
                    else
                    {
                        what_discount = "no ";
                    }
                }

                Console.WriteLine("Your price is " + price + "$ with " + what_discount + "discount :)");
                #endregion

            }

            discounts();
        }






        #endregion
    }




}
