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

            //search_mail();

            ai();


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

        static void search_mail()
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

    }


        #endregion

}
