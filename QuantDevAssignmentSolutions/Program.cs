


/*
 * The Probability of someone losing all his money is 0.5 to the power of the number of coin flips i.e:
 * 
 * For someone to get 10 tails in a row and lose all their 10$ is 0.5^10 * 100 = 0.09765625% chance of it happening.
 * 
 * However the amount of coin flips can vary greatly, and someone does not need to get 10 tails in a row to lose all his/her money,
 * all someone needs is for their amount of tail sides to exceed the number of head sides that they get.
 * someone could get a variety of heads and tails and still lose all their money.
 * 
 * My simulation counts the number of coin flips that happened when someone gets 0$ and then calculates
 * the probability that that event would have happened. 
 * 
 * The simulation does 10000 coin flips until someone gets 0$.
 * 
 * Most of the times someone never goes to 0$ as 0.5^10000 is such a small number that it's akin to 0 - so zero chances of his/her money ever
 * going to 0$ after a certain initial dollar amount is reached.
 * 
 * Most of my simulation runs show that someone loses all their money in the first 20-50 or so coin flips, after that it's 
 * highly likely the simulation will run forever and someone will never lose their money.
 * 
 * 
 * 
 * 
 * 
 * 
 */




Random rnd = new Random();

int amount = 10;

int iteration = 0;
while (amount > 0)
{


    int totalAmountOfCoinFlips = 0;
    for (int i = 0; i <= 9999; i++)
    {
        

        int coinSide = rnd.Next(1, 3);
        if (coinSide == 1)
        {
            amount += 2;
            totalAmountOfCoinFlips++;
        }
        else
        {
            amount -= 1;
            totalAmountOfCoinFlips++;
        }

        if (amount <= 0)
        {
            var probability = Math.Pow(0.5, totalAmountOfCoinFlips) * 100;

            Console.WriteLine("Amount: " + amount + "$");
            Console.WriteLine("The Probability that this event would occur is: " + probability + "%");
            Console.WriteLine("Their were "+ totalAmountOfCoinFlips + " coin flips on the iteration that 0$ occured");
            Console.WriteLine("The simulation did 10000 coin flips " + iteration + " times until someone would have lost all his/her money");
            break;
        }

        if (i == 9999)
        {
            amount = 10;
            totalAmountOfCoinFlips = 0;
        }
    }
    iteration++;
    
}