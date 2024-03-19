namespace Vecka_5
{
    internal class Program { 

        static void print(string txt)
        {
            Console.WriteLine(txt);
        }

        static void Main(string[] args)
        {



            //count();

            //searchMail();

            //ai();

            //intrestCalc(0.5);

            //string[] firstNames = {"Jhon", "Jerramy", "Jake", "Jakob" };
            //string[] lastNames = { "Momma", "Brown", "White", "Whiter" };
            //string[][] Users = { firstNames, lastNames };

            //userSys(Users);

            //donation("Jake white", 200);

            //circle(10);

            //print($"the temperature is {temp(20)} fahrenheit");


            //print($"Your input was the value {input()}");

         
        }


        #region övning 6
        static void count()
        {

            int counter = 0;

            int goal = 10;

            while (counter != goal)
            {

                Console.WriteLine("the goal hasn't been reached yet, current number is " + counter);

                counter++;

            }

            Console.WriteLine("The goal has been reached");

        }

        static void searchMail()
        {
            string[] emails_list = { "greger97@gmaail.com", "anders55@hotmail.com", "viktigpete@icloud.com" };

            Console.WriteLine("\n\nskriv ditt sök ord\n");
            string search = Console.ReadLine();

            foreach (string email in emails_list)
            {
                if (email.Contains(search)){
                    Console.WriteLine(email);
                }

                }

            }
        static void ai()
        {
            bool oncoming_car = true;
            Random rnd = new Random();


            while (oncoming_car == true) 
            {
                int traffic = rnd.Next(0,10);

                if (traffic == 0)
                {
                    print("The AI chooses to walk across since there are no cars on the road");
                    oncoming_car = false;
                }
                else
                {
                    print("The AI chooses to wait since there are " + traffic + " cars on the road");
                }




            }



        }

        static void intrestCalc(double intrestValue = 0.05, double startCap = 500)
        {
            double currentValue = startCap;
            double yearAmount = 0;
            intrestValue += 1;
            
            
            while (currentValue < startCap * 10) {
                yearAmount += 1;
                currentValue = currentValue * intrestValue;
            }

            Console.WriteLine($"It will take you {yearAmount} years  to 10 times double your start capital \n with an intrest of {(intrestValue -1) * 100}% and you will end up with {currentValue}$");
        }

        static void userSys(string[][] userList)
        {
            List<string> userNameList = new List<string>();
            bool tooMany = false;
            string userName;
            if (userList[0].Count() == userList[1].Count())
            {
                for (int i = 0; i < userList[0].Count(); i++)
                {
                    userName = userList[0][i].Substring(0, 3);
                    userName += userList[1][i].Substring(0, 3);

                    for (int j = 0; j < 1000; j++)
                    {
                        if (userNameList.Contains(userName) == true)
                        { 
                            if (j == 1000)
                            {
                                tooMany = true;
                                print("there are too many users like this");
                                break;
                            }
                            userName += j;
                            break;
                        }
                    }
                    if (tooMany == false)
                    {
                        userNameList.Add(userName);
                        print($"added {userName}");
                    }
                }
                
                for (int i = 0; i < userNameList.Count(); i++)
                {
                    print(userNameList[i]);
                }
            }   
            
            else
            {
                print("a úser is missing a field");
            }

        }

        #endregion


        #region Övning 7

        static void donation(string name, int amount)
        {

            print($"We have a new donation, {name} has donated {amount}$ to the charity");

        }

        static void circle(double radius)
        {
            double pi = 3.1416;
            double area = Math.Pow(radius, 2) * pi;

            print($"Your area is {area} a.u");

        }


        #endregion

        #region övning 9

        static double temp(double celcius)
        {

            double farenheit = (celcius * 9 / 5) + 32;

            return farenheit;
        }

        static int input()
        {
            int value;

            print("Hello please enter a value that you would like to turn into a interger");
            while (true)
            {

                try
                { 
                
                    value = int.Parse(Console.ReadLine());
                    break;
                }

                catch (System.FormatException)
                {
                    print("You cannot use letters!");
                }
                

                

            }

            return value;
            
        }

        #endregion
    }


}
        


    






