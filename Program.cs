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
            bool playAgain = true;
            while (playAgain) {
                   bool converted = true;
              while (converted){
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
        
    
        Console.WriteLine("Would you like to play again? Yes or No");
        string rePlay = Console.ReadLine();

        if(rePlay == "YES" || rePlay == "Yes" || rePlay == "yes"){
            playAgain = true;
            converted = false;
            Console.Clear();
            Console.WriteLine( "play " );
            Console.WriteLine( " " );
            break;
        } 
        if(rePlay == "NO" || rePlay == "no"){
            playAgain = false;
            converted = false;
            Console.WriteLine(" ");
            Console.WriteLine( "thank you " );
            break;
        }
        else{
            converted = true;
            Console.WriteLine(" ");
            Console.WriteLine( " invaild,try again ");
            Console.WriteLine(" ");
        }
    } 
}        }
    }
}   
        


    


