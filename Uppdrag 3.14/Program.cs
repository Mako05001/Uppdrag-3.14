using System;
namespace Uppgift3._14
{
    class program
    {
       static void Main(string[]args)
        {
            Console.WriteLine("Har du gått på gymnasiet? j/n");
            string L = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            string Å = Console.ReadLine();
            int Ålder = Convert.ToInt32(Å);
            if (L == "j" && Ålder <= 22 && Ålder >= 19)
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Vi letar tyvär efter annan personal just nu");
            }
        }
    }
}