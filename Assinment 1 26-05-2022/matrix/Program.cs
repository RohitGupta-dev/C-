namespace matrix
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter value for ROWS  ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter value for Cols  ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[p,n];
           

            //printing values of array using for each loop
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Enter ROW {i} Enter Column {j} value ");
                    arr[i,j]= Convert.ToInt32(Console.ReadLine());
                }  
                Console.WriteLine();
            }

            for (int i = 0; i <p; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{arr[i,j]}  ");
                    //arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //printing the values of array using nested for loop
            Console.ReadKey();
        }
    }
}
