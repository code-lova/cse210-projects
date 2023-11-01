using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");

        Boolean start = true;
        int choice;

        while( start == true){

            Console.WriteLine("Menu Options \n");
            Console.WriteLine("1. Start Breathing Activity\n");
            Console.WriteLine("2. Start Reflection Activity\n");
            Console.WriteLine("3. Start Listing Activity\n");
            Console.WriteLine("4. Start Gratitude Activity\n");
            Console.WriteLine("5. Exit\n");

            Console.Write("Select a choice from the menu: ");
            string ans  = Console.ReadLine();
            choice = int.Parse(ans);

            if(choice == 1){
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");
                breathingActivity.StartBreathing();

            }
            
            else if(choice == 2)
            {
                Console.Clear();
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectionActivity.StartReflection();
            }

            else if(choice == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity("listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.StartListing();
            }

            else if(choice == 4)
            {
                Console.Clear();
                GratitudeActivity gratitudeActivity = new GratitudeActivity("Gratitude Activity", "This activity will help you focus on the things you are grateful for and promote a positive mindset.");
                gratitudeActivity.StartGratitude();
            }

            else if(choice == 5){

                start = false;
            }
            
        }

       

    }
}