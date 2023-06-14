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
            Console.WriteLine("************* sum array elemen *****************");//EX1
            int result = sumArrays(my2DArray);
            // sum array element function
            Console.WriteLine("arrays sum = "+result);
            // average of rows function
            Console.WriteLine();
            Console.WriteLine("***************** average of rows **************");//EX2
            double aveResult=averageArrays(my2DArray);
            Console.WriteLine( aveResult);
            Console.WriteLine();
            Console.WriteLine("************** Search for an Element ************");//EX3
            int searshResult = searchForElement(my2DArray, 76);
            Console.WriteLine( searshResult);
            //Console.WriteLine(searchForElement(my2DArray,10);

            Console.WriteLine();
            Console.WriteLine("************** transposing matrix ************");//EX4

            int[,] tM= transposeMatrix(my2DArray);
            for(int i = 0;i < tM.GetLength(0); i++)
            {
                for(int j = 0;j < tM.GetLength(1); j++)
                {
                    Console.Write(tM[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int sumArrays(int[,] arr)//Exercise 1: Calculate the Sum of all Elements

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

        static double averageArrays(int[,] arr)//Exercise 2: Find the Average of each Row

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

        static int searchForElement(int[,] arr, int element) //Exercise 3: Search for an Element

        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {

                    if (arr[row, col] == element)
                    {
                         Console.WriteLine("The element is in position "+row+col);
                        return 1;
                    }
                }
            }
            //Console.WriteLine("The element is absent");
            return -1;



        }

        static int[,] transposeMatrix(int[,] matrix)//Exercise 4: Transpose a Matrix
        {
            int row = matrix.GetLength(0);
            int col = matrix.GetLength(1);

            int [,] transposedmatrix = new int [col, row]; // creating new matrix to hold transposed matrix

            for (int i=0; i < row;i++)
            {
                for (int j=0; j < col;j++)
                {
                    transposedmatrix[j,i] = matrix[i,j];
                }
            }
            return transposedmatrix;

        }



    }
}