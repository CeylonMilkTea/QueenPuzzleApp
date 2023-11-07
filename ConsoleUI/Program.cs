using QueenPuzzleLibrary;

int queenSize = 8;
int solutionCount = 1;

CalculateQueenPuzzle calculateQueenPuzzle =new CalculateQueenPuzzle(queenSize);
List<int[]> queenPuzzleResult = calculateQueenPuzzle.Result();
Console.WriteLine($"There are {queenPuzzleResult.Count} answers in total");
Console.WriteLine();
Console.WriteLine("The results are arranged as follows: ");
Console.WriteLine();


foreach (var queenPos in queenPuzzleResult)
{
    Console.WriteLine($"//Solution{solutionCount}: ");
    for (int i = 0; i < queenSize; i++)
    {
        for (int j = 0; j < queenSize; j++)
        {
            if (j == queenPos[i])
            {
                Console.Write("Q");
            }
            else
            {
                Console.Write(".");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    solutionCount++;
}
Console.ReadLine();