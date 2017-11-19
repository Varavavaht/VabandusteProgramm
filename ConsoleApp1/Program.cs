using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var vabandused = new List<string>
            {
                "Sa tõlgendasin seda kohustust valesti!",
                "Sul ei olnud piisavalt infot!",
                "Määratud tähtaeg on ebamõistlikult lühike!",
                "Arvasid, et keegi teine pidi selle ära tegema!",
                "See asi vajab tegelikult sügavamat analüüsi.",
                "Sa ei mäleta, et sa sellise kohustusega nõus oleksin olnud.",
                "Sa olin ebaadekvaatne kui selle tegemisega nõustusin!",
                "Sul ei võimaldatud seda teha!"
            };
            Random rnd = new Random();
            int index = rnd.Next(vabandused.Count);
            var vabandus = vabandused[index];

            //vabandus[0] = "Ma tõlgendasin seda kohustust valesti";
            //vabandus[1] = "Mul ei olnud piisavalt infot";
            //vabandus[2] = "Määratud tähtaeg on ebamõistlikult lühike";
            //vabandus[3] = "Arvasin, et keegi teine pidi selle ära tegema";
            //vabandus[4] = "See asi vajab tegelikult sügavamat analüüsi";
            //vabandus[5] = "Ma ei mäleta, et ma sellise kohustusega nõus oleksin olnud";
            //vabandus[6] = "Ma olin ebaadekvaatne kui selle tegemisega nõustusin";
            //vabandus[7] = "Mul ei võimaldatud seda teha";

            //int[] numbers = new[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            //int[] shuffled = numbers.OrderBy(n => Guid.NewGuid()).ToArray();

            Console.WriteLine("Juhul kui oled hädas, siis kasuta vabanduste programmi!");
            Console.WriteLine("Kiire vastus garanteeritud!");
            Console.Write("Vajuta alustamiseks suvalist klahvi: ");
            Console.ReadKey();
            Console.WriteLine(); //rea vahe
            Console.WriteLine();
            Console.WriteLine("Näiteks: " + vabandus);
            Console.WriteLine();
            vabandused.RemoveAt(index);
            Console.WriteLine("Juhul kui sa vajad paremat vabandust, siis vajuta klahvi nr 1.");
            Console.WriteLine("Programmist väljumiseks vajuta klahvi nr 2.");
            Console.Write("Tee valik: ");
            ConsoleKeyInfo input = Console.ReadKey();
            int sisend = int.Parse(input.KeyChar.ToString()); // use Parse if it's a Digit
            if (sisend == 1)
            {
                bool tegevus = true;
                while (tegevus)
                {
                    int index2 = rnd.Next(vabandused.Count);
                    var vabandus2 = vabandused[index2];
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Näiteks: " + vabandus2);
                    Console.WriteLine();
                    vabandused.RemoveAt(index2);
                    
                    if (vabandused.Count < 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Kahjuks ütleb keerukas algoritm, et sul pole võimalik ennast välja vabandada.");
                        Console.WriteLine("Mine otse vangi, sa ei saa GO-st 200 $");
                        break;
                    }
                    Console.WriteLine("Juhul kui sa vajad paremat vabandust, siis vajuta klahvi nr 1.");
                    Console.WriteLine("Programmist väljumiseks vajuta klahvi nr 2.");
                    Console.Write("Tee valik: ");
                    ConsoleKeyInfo input2 = Console.ReadKey();
                    int sisend2 = int.Parse(input2.KeyChar.ToString()); // use Parse if it's a Digit
                    
                    if (sisend2 == 2)
                    {
                        break;
                    }
                    
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Tänan kasutamast!");
            Console.WriteLine("Programmi autor ei vastuta käesolevas programmis toodud vabanduste kasutamisest tulenevate tagajärgede eest.");
            Console.ReadLine();
        }





    }
}


