//string secret = "bibby";
//int numOfLives = 3;

//Console.WriteLine("You have 3 lives.");
//Console.Write("Enter the secret word: ");
//string choice = Console.ReadLine();
//numOfLives--;

//while (choice != secret && numOfLives > 0)
//{
//    Console.WriteLine("You have {0} lives.", numOfLives);
//    Console.Write("Enter the secret word: ");
//    choice = Console.ReadLine();
//    numOfLives--;
//}

//if  (choice == secret)
//{
//    Console.WriteLine(" You win");
//}
//else
//{
//    Console.WriteLine(" You Lose");

//}
//second code

//Console.WriteLine(GetPow(3,5));

//static int GetPow(int baseNum, int powNum)

//{
//    int pow = baseNum;

//    for (int i = 1; i < powNum; i++)
//    {
//        pow = pow*baseNum;
//    }

//    return pow;
//}
// third code with objects and classes and methods

using HelloCsharp;

Book book1 = new Book("diary of a wimpy kid", "jeff kiney", 400);
Book book2 = new Book("BFG", "dahl", 100);

Console.WriteLine(book2.IsNovel());
Console.WriteLine(book1.FirstName());
Console.WriteLine(book1.Author);

