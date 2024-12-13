using System.Text;

namespace Assignment04
{
    internal class Program
    {
        static (int sum, int sub) CalculateSumAndSub(int a, int b, int c, int d)
        {
            int sum = a + b + c + d;
            int sub = (a + b) - (c + d);
            return (sum, sub);
        }
        static int CalculateSumOfDigits(int Num)
        {
            int Resault = 0;
            while(Num !=0)
            {
                Resault += Num % 10;
                Num /= 10;
            }
            return Resault;
        }
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static long CalcFactorial(int num)
        {
            long Fact = 1;
            if (num < 0)
            {
                return 0;
            }
            else if (num <=1)
            {
                return 1;
            }
            else
            {
                for (int i = 2; i <= num; i++)
                {
                    Fact *= i;
                }
            }
            return Fact;
        }
        static StringBuilder ChangeChar(string input, int index, char ch)
        {
            StringBuilder Output = new StringBuilder();
            Output.Append(input);
            Output[index] = ch;
            return Output;
        }
        static void Main(string[] args)
        {
            #region Ex1
            //Console.WriteLine("Enter 3 Points to Check if they are on a single line:");
            //double[] Point1 = new double[2];
            //double[] Point2 = new double[2];
            //double[] Point3 = new double[2];
            //Console.WriteLine("Enter Point1 X:");
            //Point1[0] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point1 Y:");
            //Point1[1] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point2 X:");
            //Point2[0] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point2 Y:");
            //Point2[1] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point3 X:");
            //Point3[0] = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Point3 Y:");
            //Point3[1] = double.Parse(Console.ReadLine());
            //double P12Y = (Point2[1] - Point1[1]);
            //double P12X = (Point2[0] - Point1[0]);
            //double P23Y = (Point3[1] - Point2[1]);
            //double P23X = (Point3[0] - Point2[0]);
            //bool IsOnASingleLine;
            //if (P12X == 0 && P23X == 0)
            //{
            //    IsOnASingleLine = true;
            //}
            //else if (P12X == 0 || P23X == 0)
            //{
            //    IsOnASingleLine = false;
            //}
            //else
            //{
            //    IsOnASingleLine = (P12Y / P12X) == (P23Y / P23X);
            //}
            //if (IsOnASingleLine)
            //{
            //    Console.WriteLine("Points are on a single line");
            //}
            //else
            //{
            //    Console.WriteLine("Point are not on a single line");
            //}
            #endregion
            #region Ex2
            //double Duration = double.Parse(Console.ReadLine());
            //if (Duration <= 3)
            //{
            //    Console.WriteLine("High Efficient");
            //}
            //else if (Duration <= 4)
            //{
            //    Console.WriteLine("You are instructed to increase your speed");
            //}
            //else if (Duration <= 5)
            //{
            //    Console.WriteLine("You should take training");
            //}
            //else
            //{
            //    Console.WriteLine("You Are Fired");
            //}
            #endregion
            #region Ex3
            //Console.WriteLine("Enter the size of the matrix:");
            //int size = int.Parse(Console.ReadLine());
            //int[,] Matrix = new int[size,size];
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        if (i == j)
            //        {
            //            Matrix[i,j] = 1;
            //        }
            //        else
            //        {
            //            Matrix[i, j] = 0;
            //        }
            //    }
            //}
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write(Matrix[i,j]);
            //        if (j == size - 1)
            //        {
            //            Console.WriteLine("");
            //        }
            //    }
            //}
            #endregion
            #region Ex 20
            //Console.WriteLine("Enter the size of the array:");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter Element {i+1}");
            //    arr[i] = int.Parse(Console.ReadLine()) ;
            //}
            //int sum = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    sum += arr[i];
            //}
            //Console.WriteLine(sum);
            #endregion
            #region Ex 21
            //Console.WriteLine("Enter the size of the first array:");
            //int size1 = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[size1];
            //for (int i = 0; i < size1; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1}");
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Enter the size of the second array:");
            //int size2 = int.Parse(Console.ReadLine());
            //int[] arr2 = new int[size2];
            //for (int i = 0; i < size2; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1}");
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //int MergedSize = arr1.Length + arr2.Length;
            //int[] Merged = new int[MergedSize];
            //int Index1 = 0, Index2 = 0, IndexMerged = 0;
            //while (Index1 < arr1.Length && Index2 < arr2.Length)
            //{
            //    if (arr1[Index1] <= arr2[Index2])
            //    {
            //        Merged[IndexMerged] = arr1[Index1];
            //        Index1++;
            //    }
            //    else
            //    {
            //        Merged[IndexMerged] = arr2[Index2];
            //        Index2++;
            //    }
            //    IndexMerged++;
            //}
            //while (Index1 < arr1.Length)
            //{
            //    Merged[IndexMerged] = arr1[Index1];
            //    Index1++;
            //    IndexMerged++;
            //}
            //while (Index2 < arr2.Length)
            //{
            //    Merged[IndexMerged] = arr2[Index2];
            //    IndexMerged++;
            //    Index2++;
            //}
            //for (int i = 0; i < Merged.Length; i++)
            //{
            //    Console.WriteLine(Merged[i]);
            //}
            #endregion
            #region Ex 22
            //Console.WriteLine("Enter the size of the array");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //int count = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1}");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int[] Sorted = new int[size];
            //Array.Copy(arr, Sorted, size);
            //Array.Sort(Sorted);
            //for (int i = 0; i < size; i++)
            //{
            //    count++;
            //    if (i == size - 1 || Sorted[i+1] != Sorted[i] )
            //    {
            //        Console.WriteLine($"Frequency of {Sorted[i]} = {count}");
            //        count = 0;
            //    }
            //}
            #endregion
            #region Ex23
            //Console.WriteLine("Enter the size of the array");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1}");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int max, min;
            //max = int.MinValue;
            //min = int.MaxValue;
            //for (int i = 0; i < size; i++)
            //{
            //    if (arr[i] > max)
            //    {
            //        max = arr[i];
            //    }
            //    if (arr[i] < min)
            //    {
            //        min = arr[i];
            //    }
            //}
            //Console.WriteLine($"The max element is {max} and the min element is {min}");
            #endregion
            #region Ex24
            //Console.WriteLine("Enter the size of the array");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //if (size < 2)
            //{
            //    Console.WriteLine("Error! Arrays must have 2 elements atleast to determine the second largest element");
            //}
            //else
            //{
            //    for (int i = 0; i < size; i++)
            //    {
            //        Console.WriteLine($"Enter Element {i + 1}");
            //        arr[i] = int.Parse(Console.ReadLine());
            //    }
            //    int max = arr[0];
            //    int secondMax = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        if (arr[i] > max)
            //        {
            //            secondMax = max;
            //            max = arr[i];
            //        }
            //        else if (arr[i] > secondMax && arr[i] != max)
            //        {
            //            secondMax = arr[i];
            //        }
            //    }
            //    Console.WriteLine("second largest element = " + secondMax);
            //}
            #endregion
            #region Ex25
            //Console.WriteLine("Enter the size of the array");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1}");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int Distance = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            if (Distance < j - i - 1)
            //            {
            //                Distance = j - i - 1;
            //            }
            //        }
            //    }
            //}
            //if (Distance == 0)
            //{
            //    Console.WriteLine("No Duplicated Elements");
            //}
            //else
            //{
            //    Console.WriteLine($"Distance = {Distance}");
            //}
            #endregion
            #region Ex 26
            //Console.WriteLine("Enter space seperated Words:");
            //string Input = Console.ReadLine();
            //string[] Resault = Input.Split(' ');
            //StringBuilder Reversed = new StringBuilder();
            //for (int i = Resault.Length - 1; i >= 0; i--)
            //{
            //    Reversed.Append(Resault[i] + " "); 
            //}
            //Console.WriteLine(Reversed);
            #endregion
            #region Ex 27
            //Console.WriteLine("Enter the number of rows:");
            //int rows = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the number of columns:");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] Arr1 = new int[rows, cols];
            //int[,] Arr2 = new int[rows, cols];

            //Console.WriteLine("Enter the elements of the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element [{i},{j}]: ");
            //        Arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Arr2[i, j] = Arr1[i, j];
            //    }
            //}

            //Console.WriteLine("Elements of the second array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(Arr2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Ex 28
            //Console.WriteLine("Enter the size of the array");
            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    Console.WriteLine($"Enter Element {i + 1}");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Array in reversed order:");
            //for (int i = size - 1; i >= 0; i--)
            //{
            //    Console.Write(arr[i] + " ");
            //}
            #endregion
            #region Functions
            #region Ex 3
            //Console.WriteLine("Enter 4 numbers");
            //int Num1 = int.Parse(Console.ReadLine());
            //int Num2 = int.Parse(Console.ReadLine());
            //int Num3 = int.Parse(Console.ReadLine());
            //int Num4 = int.Parse(Console.ReadLine());
            //(int sum, int sub) = CalculateSumAndSub(Num1, Num2, Num3, Num4);
            //Console.WriteLine($"The sum of the numbers is: {sum}");
            //Console.WriteLine($"The sub of the numbers is: {sub}");
            #endregion
            #region Ex 4
            //Console.WriteLine("Enter a number");
            //int Num = int.Parse(Console.ReadLine());
            //int res = CalculateSumOfDigits(Num);
            //Console.WriteLine(res);
            #endregion
            #region Ex 5
            //Console.WriteLine("Enter a number");
            //int Num = int.Parse(Console.ReadLine());
            //bool Prime = IsPrime(Num);
            //Console.WriteLine(Prime);
            #endregion
            #region Ex 7
            //Console.WriteLine("Enter a number");
            //int Num = int.Parse(Console.ReadLine());
            //long Factorial;
            //Factorial = CalcFactorial(Num);
            //if (Factorial == 0)
            //{
            //    Console.WriteLine("Error! No Factorial for negative numbers");
            //}
            //else
            //{
            //    Console.WriteLine(Factorial);
            //}
            #endregion
            #region Ex 8
            //Console.WriteLine("Enter a string");
            //string input = Console.ReadLine();
            //Console.WriteLine("Enter the index of character wanted to be changed");
            //int index = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the new character");
            //char ch = char.Parse(Console.ReadLine());
            //StringBuilder Output = ChangeChar(input, index, ch);
            //Console.WriteLine(Output);
            #endregion
            #endregion
        }
    }
}
