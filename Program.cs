using System.Runtime.Intrinsics.X86;

namespace _2DArraya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int totalRows = 3;
            int totalCols = 2;
            string[,] my2DArray = new string[totalRows, totalCols]; // 2d array
            my2DArray[0, 0] = "00";
            my2DArray[0, 1] = "01";
            my2DArray[1, 0] = "10";
            my2DArray[1, 1] = "11";
            my2DArray[2, 0] = "20";
            my2DArray[2, 1] = "21";
            

            for(int i = 0; i < totalRows; i++) //first way to do it 
            {
                for(int j = 0; j < totalCols; j++)
                {
                    Console.Write(my2DArray[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("==================");
            for (int i = 0; i <my2DArray.GetLength(0); i++) //second way to do it 
            {
                for (int j = 0; j <my2DArray.GetLength(1); j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            */
            Console.Write(" Write a program that takes a 2D array of integers as input ");
            Console.WriteLine("and calculates the sum of all the elements in the array. Display the sum as the output.");

            int totalRows = 3;
            int totalCols = 2;
            int[,] my2DArray = new int[totalRows, totalCols]; // 2d array
            my2DArray[0, 0] = 10;
            my2DArray[0, 1] = 20;
            my2DArray[1, 0] = 16;
            my2DArray[1, 1] = 34;
            my2DArray[2, 0] = 56;
            my2DArray[2, 1] = 76;
            for(int i = 0; i < totalRows; i++)
            {
                for(int j = 0; j < totalCols; j++)
                {
                    Console.Write(my2DArray[i, j] + " ");
                }
                Console.WriteLine();
            }
           Console.WriteLine();
            int result = sumArrays(my2DArray);
            // sum array element function
            Console.WriteLine("arrays sum = "+result);
            // average of rows function
            double aveResult=averageArrays(my2DArray);
            Console.WriteLine( aveResult);
        }
        static int sumArrays(int[,] arr)
        {


            int sum = 0;
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    //Console.Write(my2DArray[i, j] + " ");
                    sum = sum + arr[row, col];
                }
                //Console.WriteLine();

            }
            //Console.WriteLine("the sum of array elements is = " + sum);
            return sum;
        }

        static double averageArrays(int[,] arr)
        {
            double avg = 1;
            
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                double sum = 0;

                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    sum = sum + arr[row, col];
                }

                avg = sum / arr.GetLength(1);
                Console.WriteLine("Average value for row "+row+" = "+  avg);
                
            }
            return 1;
            

        }
    }
}