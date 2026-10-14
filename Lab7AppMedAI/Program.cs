// Ludvig Revhom Hedman NET26
using System.ComponentModel;

namespace Lab7AppMedAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> //string list with 60 words
            {
                //60 ord AI generarade
                // Lätt (3–4 bokstäver) Index 0–19
                "hund", "katt", "häst", "mus",
                "ko", "gris", "anka", "fisk",
                "boll", "bok", "stol", "bord",
                "dörr", "film", "spel", "träd",
                "sol", "måne", "snö", "hus",

                // Medel (5–7 bokstäver) Index 20–39
                "gurka", "banan", "äpple", "citron",
                "morot", "tomat", "potatis", "giraff",
                "elefant", "delfin", "kanin", "tiger",
                "skola", "penna", "cykel", "gitarr",
                "telefon", "laddare", "fotboll", "springa",

                // Svår (9–10 bokstäver) Index 40–59
                "jordgubbe", "krokodiler", "musmattor", "skrivbord",
                "bibliotek", "basketboll", "suddgummi", "fågelungar",
                "glasskula", "vattenfall", "skolböcker", "blomkruka",
                "tandborste", "regnjacka", "regnbyxor", "fotbollar",
                "bokhyllor", "chokladbit", "brandbilar", "fiskpinnar"
            };

            Random random = new Random(); // creats a new random generator 

            Console.WriteLine("-----Gissa Ordet-----");
            Console.WriteLine("Välkommen till gissa ordet");
            Console.WriteLine("Din uppgift är att gissa vad ordet är med hjälp av blandade bokstäver");
            Console.Write("Viken svårighets grad vill du köra i?\n1.Lätt (3–4 bokstäver)\n2.Medel (5–7 bokstäver)\n3.Svår (9–10 bokstäver)\n:");

            int choise;
            while (!int.TryParse(Console.ReadLine(), out choise) || choise < 1 || choise > 3) //while loop with a try parse to check so its a accepteble number
            {
                Console.WriteLine("Fel du måste skriva ett gilltigt nummer");
            }

            Console.WriteLine("Kan du lista ut ordet du har 3 försök");

            string rightWord = "";

            switch (choise)// switch case to randomly generate a word based on the dificulty
            {
                case 1:
                    rightWord = words[random.Next(0, 20)];
                    ScrambleWords scrambleEasy = new ScrambleWords(rightWord);// creates a new object 
                    Console.WriteLine(scrambleEasy.ScrambleWord());//calls the method to scamble the word and print the scrambled vertion 
                    break;

                case 2:
                    rightWord = words[random.Next(20, 40)];
                    ScrambleWords scrambleMeduim = new ScrambleWords(rightWord);
                    Console.WriteLine(scrambleMeduim.ScrambleWord());
                    break;

                case 3:
                    rightWord = words[random.Next(40, 60)];
                    ScrambleWords scrambleHard = new ScrambleWords(rightWord);
                    Console.WriteLine(scrambleHard.ScrambleWord());
                    break;
            }


            for(int i = 0; i < 3; i++) // for loop that checks if the the input from user is the same as the right word and prints if you win loos or need to try again 
            { 
                string attempt = Console.ReadLine();

                if (rightWord == attempt)
                {
                    Console.WriteLine($"Du gissade rätt!, ordet va {rightWord}");
                    break;
                }
                else if(i == 2)
                {
                    Console.WriteLine($"Du lyckades inte gissa rätt, ordet va {rightWord}");
                }
                else
                {
                    Console.WriteLine("Du gissade fel försök igen");
                }
            }
        }
    }
}
