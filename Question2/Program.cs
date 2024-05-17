
using QuestionTwo;
using System.Text;


string[,] battleshipLocations = { { "0", "X", "0", "0", "0", "0" },
                                  { "X", "0", "X", "0", "0", "0" },
                                  { "0", "X", "0", "X", "0", "0" },
                                  { "0", "X", "0", "0", "X", "X" }};


FindBattleships findBattleships = new FindBattleships();


int battleships = findBattleships.CalculateBattleships(battleshipLocations);

Console.WriteLine(battleships);

