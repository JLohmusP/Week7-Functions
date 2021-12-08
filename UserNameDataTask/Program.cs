using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //küsi kasutaja eesnime
            //küsi kasutajal sisestada numbrit 1-3
            //kui 1, kuva kasutaja eesnimi tagurpidi
            //kui 2, kuva kasutaja eesnime esimene täht
            //kui 3, kuva kasutaja eesnime pikkus

            Console.WriteLine("Sisesta oma eesnimi:");
            string userName = Console.ReadLine();
            Console.WriteLine("Palun sisesta arv 1-3.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    UserNameBackwards(userName);
                    break;

                case 2:
                    UserNameFirstLetter(userName);
                    break;

                case 3:
                    UserNameLength(userName);
                    break;

                default:
                    Console.WriteLine("Sisestatud vale number. Proovi uuesti.");
                    break;
            }
        }

        public static void UserNameBackwards(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void UserNameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}.");
        }

        public static void UserNameLength(string userInput)
        {
            Console.WriteLine($"Sinu eesnimi on {userInput.Length} sümbolit pikk.");
        }
    }
}
