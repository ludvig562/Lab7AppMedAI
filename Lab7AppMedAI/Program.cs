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
            while (!int.TryParse(Console.ReadLine(), out choise) || choise < 1 || choise > 4)
            {
                Console.WriteLine("Fel du måste skriva ett gilltigt nummer");
            }

            switch (choise)
            {
                case 1:
                    string easyWord = words[random.Next(0, 20)];
                    ScrableWords scrambleEasy = new ScrableWords(easyWord);
                    Console.WriteLine(scrambleEasy.ScrableWord());
                    break;

                case 2:
                    string mediumWord = words[random.Next(20, 40)];
                    ScrableWords scrambleMeduim = new ScrableWords(mediumWord);
                    Console.WriteLine(scrambleMeduim.ScrableWord());
                    break;

                case 3:
                    string hardWord = words[random.Next(40, 60)];
                    ScrableWords scrambleHard = new ScrableWords(hardWord);
                    Console.WriteLine(scrambleHard.ScrableWord());
                    break;
            }

            
        }
    }
}
