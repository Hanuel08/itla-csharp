namespace practice_4;

public class Matrix
{
    public static void Show()
    {
        string[,] matrix =
        {
            {"A", "B", "C"},
            {"D", "E", "F"},
            {"G", "H", "I"},
        };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }
}