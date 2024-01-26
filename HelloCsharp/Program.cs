string secret = "bibby";
int numOfLives = 3;

Console.WriteLine("You have 3 lives.");
Console.Write("Enter the secret word: ");
string choice = Console.ReadLine();
numOfLives--;

while (choice != secret && numOfLives > 0)
{
    Console.WriteLine("You have {0} lives.", numOfLives);
    Console.Write("Enter the secret word: ");
    choice = Console.ReadLine();
    numOfLives--;
}

if  (choice == secret)
{
    Console.WriteLine(" You win");
}
else
{
    Console.WriteLine(" You Lose");

}