using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_headFirstCsharp_st_195
{
    class Elephant
    {
        

       public string Name = "";
       public int EarSize = 0;

        // Start a program where user has to select which option to run 
        // string key - option that user has to select 
        // WhoAmI function - writes on a console Name of the object and EarSize 
        // SpeakTo function - just an example how ".this" operation works in C# 
        // Swap - do swap of two objects 
        // HearMessage - presents a mesage from an object to another Elephant object 
        public static void StartElephantProgram(Elephant first, Elephant second )
        {
            string key;
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 to swap");
            key = Console.ReadLine();

            if (key == "1")
            {
                first.WhoAmI();
            }

            else if (key == "2")
            {
                second.WhoAmI();
            }
            else if (key =="4")
            {
                first.SpeakTo(second, "Hi " + second.Name);
            }
            else
            {
                first.Swap(first,second);
            }
        }

        public void WhoAmI()
        {
            Console.WriteLine("Hello my name is {0} ", Name);
            Console.WriteLine("My ears are {0} inches tall ", EarSize);

        }

        public void Swap(Elephant first, Elephant second)
        {
             Elephant backToNormal;
             backToNormal = first;
             first = second;
             second = backToNormal;

             second.WhoAmI();
             first.WhoAmI();
               
 
            
        }

        public void HearMessage(string message, Elephant whoSaidIt)
        {
            Console.WriteLine(Name + " Heard a message ");
            Console.WriteLine(whoSaidIt.Name + " said this: " + message);

        }
        public void SpeakTo(Elephant whoToTalkTo, string message)
        {
            whoToTalkTo.HearMessage(message, this);

        }

    }
}
