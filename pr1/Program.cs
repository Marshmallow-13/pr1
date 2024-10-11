public class Matr
{
    static void Main()
    {
        Console.Write("Введите кол-во строк матрицы:");
        int row =int.Parse(Console.ReadLine());
        Console.Write("Ввелите кол-во столбцов матрицы:");
        int col =int.Parse(Console.ReadLine());
        int[,] matrix = new int[row,col];
        Random rand = new Random();
        Console.WriteLine("Исходная матрица:");
        for(int i = 0; i < row; i++)
        {
            for(int j = 0; j < col; j++)
            {
                matrix[i, j] = rand.Next(1, 10);
                Console.Write(matrix[i, j]+"\t");
            }
            Console.WriteLine();
        }
        int[,] transp = new int[col,row];
        for(int i = 0;i < row; i++)
        {
            for(int j = 0;j < col; j++)
            {
                transp[j,i] = matrix[i,j];
            }
        }
        Console.WriteLine("Транспонированная матрица:");
        for(int i = 0;i<col; i++)
        {
            for (int j = 0; j < row; j++)
            {
                Console.Write(transp[i,j]+"\t");
            }
            Console.WriteLine();
        }
    }
}
