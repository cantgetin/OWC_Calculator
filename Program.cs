using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OWC_Calculator
{
    class Program
    {
        static List<Player> players = new List<Player>()
        {
            new Player("zin",313262,240681,380970,430118,249429),
            new Player("gamer",304135,164592,276305,339143,218533),
            new Player("envy_ss",254790,269645,280486,522146,268018),
            new Player("Alexandrine",114617,90715,241124,203663,63719),
            new Player("Din",386681,307250,233086,705170,209365),
            new Player("Meniwa",234594,135644,414624,318688,402128),
            new Player("Kyori",237166,151755,318293,336971,239112),
            new Player("Disaster",425733,275557,467841,324363,254690),
            new Player("Okinotori",405643,537293,382185,521972,407566),
            new Player("Skrowell",341441,239056,287428,396710,163708),
            new Player("AxewB",290040,258515,235239,221382,246300),
            new Player("azaz08967565",185197,178294,278354,201121,238800),
            new Player("desuqe",291680,223665,186826,491204,150897),
            new Player("Eban",177179,110114,482362,452841,281809)
        };

        static List<int> resultsAscOrder = new List<int>();


        static void Main(string[] args)
        {
            
            int maxSum = 0;
            int count = 0;

            StreamWriter sw = new StreamWriter("D:\\owc_calc.txt");
            List<int> currentSequence = new List<int>();

            for (int p1 = 0; p1 < players.Count; p1++)
            {
                currentSequence.Add(p1);
                for (int p2 = 0; p2 < players.Count; p2++)
                {
                    if (currentSequence.Contains(p2)) continue;
                    else
                    {
                        currentSequence.Add(p2);
                        for (int p3 = 0; p3 < players.Count; p3++)
                        {
                            if (currentSequence.Contains(p3)) continue;
                            else
                            {
                                currentSequence.Add(p3);
                                for (int p4 = 0; p4 < players.Count; p4++)
                                {
                                    if (currentSequence.Contains(p4)) continue;
                                    else
                                    {
                                        currentSequence.Add(p4);
                                        for (int p5 = 0; p5 < players.Count; p5++)
                                        {
                                            if (currentSequence.Contains(p5)) continue;
                                            else
                                            {
                                                currentSequence.Add(p5);
                                                count++;
                                                Console.WriteLine(count + ". " + players[p1].Name + " " + players[p2].Name + " " + players[p3].Name + " " + players[p4].Name + " " + players[p5].Name);
                                                sw.WriteLine(count + ". " + players[p1].Name + " " + players[p2].Name + " " + players[p3].Name + " " + players[p4].Name + " " + players[p5].Name);

                                                List<int> NM = new List<int>();
                                                NM.Add(players[p1].NM);
                                                NM.Add(players[p2].NM);
                                                NM.Add(players[p3].NM);
                                                NM.Add(players[p4].NM);
                                                NM.Add(players[p5].NM);

                                                int maxNM = NM.Max();
                                                int maxNM2 = (from number in NM orderby number descending select number).Distinct().Skip(1).First();


                                                List<int> HD = new List<int>();
                                                HD.Add(players[p1].HD);
                                                HD.Add(players[p2].HD);
                                                HD.Add(players[p3].HD);
                                                HD.Add(players[p4].HD);
                                                HD.Add(players[p5].HD);

                                                int maxHD = HD.Max();
                                                int maxHD2 = (from number in HD orderby number descending select number).Distinct().Skip(1).First();

                                                List<int> HR = new List<int>();
                                                HR.Add(players[p1].HR);
                                                HR.Add(players[p2].HR);
                                                HR.Add(players[p3].HR);
                                                HR.Add(players[p4].HR);
                                                HR.Add(players[p5].HR);

                                                int maxHR = HR.Max();
                                                int maxHR2 = (from number in HR orderby number descending select number).Distinct().Skip(1).First();


                                                List<int> DT = new List<int>();
                                                DT.Add(players[p1].DT);
                                                DT.Add(players[p2].DT);
                                                DT.Add(players[p3].DT);
                                                DT.Add(players[p4].DT);
                                                DT.Add(players[p5].DT);

                                                int maxDT = DT.Max();
                                                int maxDT2 = (from number in DT orderby number descending select number).Distinct().Skip(1).First();


                                                List<int> FM = new List<int>();
                                                FM.Add(players[p1].FM);
                                                FM.Add(players[p2].FM);
                                                FM.Add(players[p3].FM);
                                                FM.Add(players[p4].FM);
                                                FM.Add(players[p5].FM);

                                                int maxFM = FM.Max();
                                                int maxFM2 = (from number in FM orderby number descending select number).Distinct().Skip(1).First();


                                                int wholesum = maxNM + maxNM2 + maxHD + maxHD2 + maxHR + maxHR2 + maxDT + maxDT2 + maxFM + maxFM2;




                                                

                                                if (resultsAscOrder.Contains(wholesum)) wholesum = wholesum;
                                                else resultsAscOrder.Add(wholesum);

                                                if (wholesum > maxSum) maxSum = wholesum;
                                                Console.Write(
                                                    " maxNM: " + maxNM + " maxNM2: " + maxNM2 +
                                                    " maxHD: " + maxHD + " maxHD2: " + maxHD2 +
                                                    " maxHR: " + maxHR + " maxHR2: " + maxHR2 +
                                                    " maxDT: " + maxDT + " maxDT2: " + maxDT2 +
                                                    " maxFM: " + maxFM + " maxFM2: " + maxFM2 +
                                                    " sum: " + wholesum);
                                                sw.Write(
                                                     " maxNM: " + maxNM + " maxNM2: " + maxNM2 +
                                                    " maxHD: " + maxHD + " maxHD2: " + maxHD2 +
                                                    " maxHR: " + maxHR + " maxHR2: " + maxHR2 +
                                                    " maxDT: " + maxDT + " maxDT2: " + maxDT2 +
                                                    " maxFM: " + maxFM + " maxFM2: " + maxFM2 +
                                                    " sum: " + wholesum);
                                                Console.WriteLine();
                                                sw.WriteLine();
                                                
                                            }
                                            currentSequence.Remove(p5);
                                        }
                                    }
                                    currentSequence.Remove(p4);
                                }

                            }
                            currentSequence.Remove(p3);

                        }
                        

                    }
                    currentSequence.Remove(p2);
                }
                currentSequence.Clear();

            }
            resultsAscOrder.Sort();
            Console.WriteLine(maxSum);
            sw.WriteLine(maxSum);

            int counter = 0;
            for (int i = resultsAscOrder.Count - 1; i > - 1; i--)
            {
                counter++;
                Console.WriteLine(counter+". "+resultsAscOrder[i]);
                sw.WriteLine(counter + ". " + resultsAscOrder[i]);
            }

            sw.Close();
        }
    }
}
