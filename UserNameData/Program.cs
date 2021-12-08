using System;

namespace UserNameData
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutaja eesnime
            //kuva kasutaja eesnime pikkuse
            //kuva kasutaja eesnime esimese tähe
            //kuva kasutaja eesnime tagurpidi
            //main meetodis ei tohi olla kui 3 rida koodi

            Console.WriteLine("Sisesta oma eesnimi");
            string userName = Console.ReadLine();

            GetUserNameData(userName);
        }

        public static void GetUserNameData(string userInput)
        {
            Console.WriteLine($"Sinu eesnimi on {userInput.Length} sümbolit pikk.");
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");

            for(int i= userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}
