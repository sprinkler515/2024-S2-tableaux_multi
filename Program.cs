namespace _0409_S2_tableaux_multi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] uni = new int[3, 3];
            int[][] jag = new int[3][];

            FillUniArray(uni);
            FormatUniArray(uni);

            FillJagArray(jag, uni);
            FormatJagArray(jag);
        }

        static void FillUniArray(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            for (int i = 0; i < row; i++)
                for (int j = 0; j < col; j++)
                    arr[i, j] = i + j + 1;
        }

        static void FillJagArray(int[][] jag, int[,] uni)
        {
            int row = uni.GetLength(0);
            int col = uni.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                jag[i] = new int[col--];
                for (int j = 0; j < jag[i].Length; j++)
                    jag[i][j] = uni[i, i + j];
            }
        }

        static void FormatUniArray(int[,] arr)
        {
            int row = arr.GetLength(0);
            int col = arr.GetLength(1);

            Console.Write("Tableau uniforme : [");
            for (int i = 0; i < row; i++)
            {
                if (i == 0) Console.Write($"{i}");
                else Console.Write($"{i,21}");
                Console.Write(" => [");

                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arr[i, j]}");
                    Console.Write($"{(j != col - 1 ? ", " : ']')}");
                }
                if (i != row - 1) Console.WriteLine(',');
                else Console.WriteLine();
            }
        }

        static void FormatJagArray(int[][] arr)
        {
            int row = arr.Length;

            Console.Write("Tableau irrégulier : [");
            for (int i = 0; i < row; i++)
            {
                int col = arr[i].Length;

                if (i == 0) Console.Write($"{i}");
                else Console.Write($"{i,23}");
                Console.Write(" => [");

                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arr[i][j]}");
                    Console.Write($"{(j != col - 1 ? ", " : ']')}");
                }
                if (i != row - 1) Console.WriteLine(',');
                else Console.WriteLine();
            }
        }
    }
}
