using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

class PositionText
{
    class CodePage437
    {
        public static void Main(string[] args)
        {
            System.Console.OutputEncoding = System.Text.Encoding.Unicode;
            
            string[] map = new string[49];
            int num = 1;
            string[] mapCopy = new string[49];
            
          

            for (int i = 0; i < map.Length; i++) 
            {
                map[i] = Convert.ToString(num);
                mapCopy[i] = map[i];
                num++;

            }

            int player = 1;


            Console.WriteLine("You are playing for \"X\" ");

            do
            {

                do
                {
                    Console.Clear();
                    ShowTable(map);
                    Console.WriteLine();
                    if (player % 2 == 0)
                    {
                        Console.WriteLine("Player 2, it`s your turn");
                    }
                    else
                    {
                        Console.WriteLine("Player 1, it`s your turn");
                    }

                    try
                    {
                        num = int.Parse(Console.ReadLine());
                        if (num >= 1 && num <= 49)
                        {
                            if (map[num - 1] != "X" && map[num - 1] != "O")
                            {
                                if (player % 2 == 0)
                                {
                                    map[num - 1] = "O";
                                }
                                else { map[num - 1] = "X"; }

                                player++;

                                break;
                            }
                            else
                            {
                                Console.WriteLine($"The cell {num} is filled");
                                Thread.Sleep(1000);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"The cell {num} does not exist ");
                            Thread.Sleep(1000);
                        }
                    } catch(FormatException){
                        Console.WriteLine("Invalid input");
                        Thread.Sleep(1000);
                    }
                } while (true);
               
            }
            while (WinCheck(map, "X") != true && WinCheck(map, "O") != true && DrawCheck(map) != true);

            Console.Clear();
            ShowTable(map);
            Console.WriteLine();
            if (WinCheck(map, "X"))
            {
                Console.WriteLine("Player 1 won");

            }
            else if (WinCheck(map, "O"))
            {
                Console.WriteLine("Player 2 won");
            }
            else
            {
                Console.WriteLine("Draw");
            }




        }
        static void ShowTable(string[] map)
        {
            string[] mapCopy = new string[49];
            for (int i = 0; i < map.Length; i++)
            {

                mapCopy[i] = map[i];


            }
            for (int i = 0; i < map.Length; i++)
            {
                if (i >= 9 && mapCopy[i] != Convert.ToString(i + 1))
                {
                    mapCopy[i] = mapCopy[i] + " ";
                }



            }

            Console.WriteLine("                mss    yhhhhhhhy hhhhhhhhhh: hhh -   `shh  shh: :hhhhhhyo:   yhh.  .yhh  shh:");
            Console.WriteLine("              nmMMMy   NMMyoooo+ syymMMmyyy. oMMd`   +MMd` dMM/ /MMNoosNMMo  NMM- :mMN+  hMM+");
            Console.WriteLine("            :hMdyMMy   NMM          yMMs     `hMMo -NMN-   dMM/ /MMm   dMMy  NMMhyNMd-   hMM+");
            Console.WriteLine("          .yNMy  MMh   NMMdhhhh-    yMMs      `dMN/dMN/    dMM/ /MMMmNMMNo.  NMMdhNMd-   hMM+");
            Console.WriteLine("         /NNNNmmNMMNm- NMMo         yMMs       -NMNMMo     dMM/ /MMd. :dMNo` NMM- /mMN/  hMM+");
            Console.WriteLine("          `.....+mmy   dmmmmmmmd`   ommo        /mmmy`     hmm/ /ddy   `oddy dmm-  .hmmo ymm/");
            Console.WriteLine("                ```   `````````    ```         ```      ```   ```    ```  ```     ``` ```   ");

            Console.WriteLine("┏━━━━┳━━━━┳━━━━┳━━━━┳━━━━┳━━━━┳━━━━┓");
            Console.WriteLine($"┃ {mapCopy[0]}  ┃ {mapCopy[1]}  ┃ {mapCopy[2]}  ┃ {mapCopy[3]}  ┃ {mapCopy[4]}  ┃ {mapCopy[5]}  ┃ {mapCopy[6]}  ┃          Player 1: X, Player 2: O");
            Console.WriteLine("┣━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━┫");
            Console.WriteLine($"┃ {mapCopy[7]}  ┃ {mapCopy[8]}  ┃ {mapCopy[9]} ┃ {mapCopy[10]} ┃ {mapCopy[11]} ┃ {mapCopy[12]} ┃ {mapCopy[13]} ┃          The first player to get 4 of his");
            Console.WriteLine("┣━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━┫");

            Console.WriteLine($"┃ {mapCopy[14]} ┃ {mapCopy[15]} ┃ {mapCopy[16]} ┃ {mapCopy[17]} ┃ {mapCopy[18]} ┃ {mapCopy[19]} ┃ {mapCopy[20]} ┃          marks in a row (up, down, across,");
            Console.WriteLine("┣━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━┫");

            Console.WriteLine($"┃ {mapCopy[21]} ┃ {mapCopy[22]} ┃ {mapCopy[23]} ┃ {mapCopy[24]} ┃ {mapCopy[25]} ┃ {mapCopy[26]} ┃ {mapCopy[27]} ┃          or diagonally) is the winner.");
            Console.WriteLine("┣━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━┫");

            Console.WriteLine($"┃ {mapCopy[28]} ┃ {mapCopy[29]} ┃ {mapCopy[30]} ┃ {mapCopy[31]} ┃ {mapCopy[32]} ┃ {mapCopy[33]} ┃ {mapCopy[34]} ┃");
            Console.WriteLine("┣━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━┫");

            Console.WriteLine($"┃ {mapCopy[35]} ┃ {mapCopy[36]} ┃ {mapCopy[37]} ┃ {mapCopy[38]} ┃ {mapCopy[39]} ┃ {mapCopy[40]} ┃ {mapCopy[41]} ┃");
            Console.WriteLine("┣━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━╋━━━━┫");

            Console.WriteLine($"┃ {mapCopy[42]} ┃ {mapCopy[43]} ┃ {mapCopy[44]} ┃ {mapCopy[45]} ┃ {mapCopy[46]} ┃ {mapCopy[47]} ┃ {mapCopy[48]} ┃");


            Console.WriteLine("┗━━━━┻━━━━┻━━━━┻━━━━┻━━━━┻━━━━┻━━━━┛");

        }

        static bool DrawCheck(string[] map)
        {

            for (int i = 0; i < map.Length; i++)
            {
                if (map[i] != "O" && map[i] != "X")
                {
                    return false;
                }

            }
            return true;
        }
        static bool WinCheck(string[] map, string player)
        {
            int[] linesArray = { 0, 7, 14, 21, 28, 35, 42 };
            //horisontal
            foreach (int number in linesArray)
            {
                if (map[number] == player && map[number] == map[number + 1] && map[number] == map[number + 2] && map[number] == map[number + 3])
                {
                    return true;
                }
                else if (map[number + 1] == player && map[number + 1] == map[number + 2] && map[number + 1] == map[number + 3] && map[number + 1] == map[number + 4])
                {
                    return true;
                }
                else if (map[number + 2] == player && map[number + 2] == map[number + 3] && map[number + 2] == map[number + 4] && map[number + 2] == map[number + 5])
                {
                    return true;
                }
                else if (map[number + 3] == player && map[number + 3] == map[number + 4] && map[number + 3] == map[number + 5] && map[number + 3] == map[number + 6])
                {
                    return true;
                }


            }
            int[] columnsArray = { 0, 1, 2, 3, 4, 5, 6 };
            foreach (int number in columnsArray)
            {
                if (map[number] == player && map[number] == map[number + 7] && map[number] == map[number + 2 * 7] && map[number] == map[number + 3 * 7])
                {
                    return true;
                }
                else if (map[number + 1 * 7] == player && map[number + 1 * 7] == map[number + 2 * 7] && map[number + 1 * 7] == map[number + 3 * 7] && map[number + 1 * 7] == map[number + 4 * 7])
                {
                    return true;
                }
                else if (map[number + 2 * 7] == player && map[number + 2 * 7] == map[number + 3 * 7] && map[number + 2 * 7] == map[number + 4 * 7] && map[number + 2 * 7] == map[number + 5 * 7])
                {
                    return true;
                }
                else if (map[number + 3 * 7] == player && map[number + 3 * 7] == map[number + 4 * 7] && map[number + 3 * 7] == map[number + 5 * 7] && map[number + 3 * 7] == map[number + 6 * 7])
                {
                    return true;
                }


            }

            int[] diagonalArray = { 0 };
            foreach (int number in diagonalArray)
            {
                if (map[0] == player && map[0] == map[0 + 8] && map[0] == map[0 + 2 * 8] && map[0] == map[0 + 3 * 8])
                {
                    return true;
                }
                else if (map[8] == player && map[0 + 1 * 8] == map[0 + 2 * 8] && map[0 + 1 * 8] == map[0 + 3 * 8] && map[0 + 1 * 8] == map[0 + 4 * 8])
                {
                    return true;
                }
                else if (map[2 * 8] == player && map[0 + 2 * 8] == map[0 + 3 * 8] && map[0 + 2 * 8] == map[0 + 4 * 8] && map[0 + 2 * 8] == map[0 + 5 * 8])
                {
                    return true;
                }
                else if (map[3 * 8] == player && map[0 + 3 * 8] == map[0 + 4 * 8] && map[0 + 3 * 8] == map[0 + 5 * 8] && map[0 + 3 * 8] == map[0 + 6 * 8])
                {
                    return true;

                }


                else if (map[6] == player && map[6] == map[6 + 6] && map[6] == map[6 + 2 * 6] && map[6] == map[6 + 3 * 6])
                {
                    return true;
                }
                else if (map[6 + 1 * 6] == player && map[6 + 1 * 6] == map[6 + 2 * 6] && map[6 + 1 * 6] == map[6 + 3 * 6] && map[6 + 1 * 6] == map[6 + 4 * 6])
                {
                    return true;
                }
                else if (map[6 + 2 * 6] == player && map[6 + 2 * 6] == map[6 + 3 * 6] && map[6 + 2 * 6] == map[6 + 4 * 6] && map[6 + 2 * 6] == map[6 + 5 * 6])
                {
                    return true;
                }
                else if (map[6 + 3 * 6] == player && map[6 + 3 * 6] == map[6 + 4 * 6] && map[6 + 3 * 6] == map[6 + 5 * 6] && map[6 + 3 * 6] == map[6 + 6 * 6])
                {
                    return true;
                }

            }

            return false;
        }


        
    }
}
