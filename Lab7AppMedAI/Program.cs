using System.ComponentModel;

namespace Lab7AppMedAI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>
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
                "bibliotek", "basketboll", "suddgummi", "ryggsäck",
                "datormus", "fågelunge", "glasskula", "vattenfall",
                "skolböcker", "fotbollslag", "blomkruka", "tandborste",
                "brandstation", "regnjacka", "vintermössa", "solglasögon"
            };

            Random random = new Random();

            Console.WriteLine("-----Gissa Ordet-----");
            Console.WriteLine("Välkommen till gissa ordet");
            Console.WriteLine("Din uppgift är att gissa vad ordet är med hjälp av blandade bokstäver");
            Console.Write("Viken svårighets grad vill du köra i?\n1.Lätt (3–4 bokstäver)\n2.Medel (5–7 bokstäver)\n3.Svår (9–10 bokstäver)\n:");

            int choise;
            while (!int.TryParse(Console.ReadLine(), out choise) || choise < 1 || choise > 3)
            {
                Console.WriteLine("Fel du måste skriva ett gilltigt nummer");
            }

            Console.WriteLine("Kan du lista ut ordet du har 3 försök");

            string rightWord = "";

            switch (choise)
            {
                case 1:
                    rightWord = words[random.Next(0, 20)];
                    ScrambleWords scrambleEasy = new ScrambleWords(rightWord);
                    Console.WriteLine(scrambleEasy.ScrambleWord());
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


            for(int i = 0; i < 3; i++) 
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
