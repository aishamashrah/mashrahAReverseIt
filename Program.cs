//Mini Challenge # 7 - Reverse It
//09-16-22
//we Create a brand new console project that takes a sequence of numbers and reverses them.
//Then user will enter the number.
//user frindly one thing i would fix is spacing.

using System;
namespace Reverseit
{
    class program
    {
        static void Main(string [] args)
        {
            // string reverse = Console.ReadLine();
            Console.WriteLine("enter your number");
            string Originalnumber = Console.ReadLine();
            int userinput = Convert.ToInt32(Originalnumber);
             int reminder , reverse = 0; 
             while(userinput>0)
             {
               
                reminder = userinput % 10;
                reverse = reverse * 10 + reminder;
                userinput = userinput / 10;
            
             }
             Console.WriteLine("this is your number");
             Console.WriteLine(reverse);
             Console.WriteLine("");
             
        
             //  Console.ReadLine(userinput);

             Console.WriteLine($"reverse number is {reverse}");
        }
    }
}

    
        


    


