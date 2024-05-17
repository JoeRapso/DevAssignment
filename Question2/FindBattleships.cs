using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionTwo
{
    public class FindBattleships
    {
        public int CalculateBattleships(string[,] battleshipLocations)
        {
            int battleships = 0;


            for (int i = 0; i < battleshipLocations.GetLength(0); i++)
            {
                for (int j = 0; j < battleshipLocations.GetLength(1); j++)
                {
                    if (battleshipLocations[i, j] == "X")
                    {

                        string findAdjacentXs = LookRightSide(i, j, battleshipLocations);

                        if (findAdjacentXs.Contains("X"))
                        {
                            battleships++;
                        }
                    }
                }
            }

            return battleships;
        }

        private string LookLeftSide(int i, int j, string[,] battleshipLocations)
        {
            string numberOfXs = "";

            for (int k = i; k <= i; k++)
            {
                for (int l = j - 1; l > 0; l--)
                {
                    if (battleshipLocations[k, l] == "0")
                    {
                        break;
                    }
                    if (battleshipLocations[k, l] == "X")
                    {

                        numberOfXs += battleshipLocations[k, l];
                        battleshipLocations[k, l] = "-";
                        numberOfXs += LookDown(k, l, battleshipLocations);
                    }
                }
            }

            return numberOfXs;
        }

        private string LookDown(int i, int j, string[,] battleshipLocations)
        {
            string numberOfXs = "";

            for (int k = i + 1; k < battleshipLocations.GetLength(0); k++)
            {
                if (battleshipLocations[k, j] == "0")
                {
                    break;
                }

                for (int l = j; l <= j; l++)
                {

                    if (battleshipLocations[k, l] == "X")
                    {
                        numberOfXs += LookRightSide(k, l, battleshipLocations);
                        numberOfXs += LookLeftSide(k, l, battleshipLocations);
                        battleshipLocations[k, l] = "-";
                    }
                }

            }

            return numberOfXs;
        }

        private string LookRightSide(int i, int j, string[,] battleshipLocations)
        {
            string numberOfXs = "";

            for (int k = i; k <= i; k++)
            {
                for (int l = j; l < battleshipLocations.GetLength(1); l++)
                {
                    if (battleshipLocations[k, l] == "0")
                    {
                        break;
                    }
                    if (battleshipLocations[k, l] == "X")
                    {

                        numberOfXs += battleshipLocations[k, l];
                        battleshipLocations[k, l] = "-";
                        numberOfXs += LookDown(k, l, battleshipLocations);

                    }
                }
            }

            return numberOfXs;
        }
    }
}
