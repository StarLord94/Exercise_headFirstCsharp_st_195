using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_headFirstCsharp_st_195
{
    class Elephant
    {
        

       public string Name = "";
       public int EarSize = 0;
        
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
