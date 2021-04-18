using System;

namespace Exercise_headFirstCsharp_st_195
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant Lloid = new Elephant { Name = "Lloyd", EarSize = 40 };
            Elephant Lucinda = new Elephant { Name = "Lucinda", EarSize = 80 };

            Lloid.HearMessage("Hi", Lucinda );
            Lucinda.SpeakTo(Lloid,"Hi ");

            int howLong = 0;

            while (howLong == 0)
            {
                Elephant BackToNormal = new Elephant { Name = "0", EarSize = 0 };


                Elephant.StartElephantProgram(Lloid, Lucinda);
                Console.WriteLine("Do you want to continiue ?  1 = no, 0 = yes");
                string howLongSttring = Console.ReadLine();
                howLong = Int32.Parse(howLongSttring);
            }




        }
    }
}
