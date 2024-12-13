using System.Text;

namespace Session04_Demo
{
    internal class Program
    {
        public static void Print(int count, string Pattern)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Pattern);
            }
        }
        public static void PrintPattern(int count = 10, string Pattern = "$_$")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(Pattern);
            }
        }
        static void Main(string[] args)
        {
                #region String vs. StringBuilder
                //string Name01;
                //Name01 = new string("Rana");
                //string Name02 = "Heba";
                //Name02 = Name01;
                //Name01 = "Omar";
                //Console.WriteLine(Name01);
                //Console.WriteLine(Name02);
                //String is imutable and can not be changed

                //string Msg = "Hello,";
                //Console.WriteLine(Msg);
                //Console.WriteLine(Msg.GetHashCode());
                //Msg += " Route"; //Create new object with new identity
                //Console.WriteLine(Msg);
                //Console.WriteLine(Msg.GetHashCode());
                //------------------------------------------//

                //StringBuilder
                //StringBuilder SB = new StringBuilder();
                //SB.Append("Hello");
                //Console.WriteLine(SB);
                //Console.WriteLine(SB.GetHashCode());
                //SB.Append(" Route");
                //Console.WriteLine(SB);
                //Console.WriteLine(SB.GetHashCode());
                // StringBuilder is Reference Type and work as reference type

                #endregion
                #region Arrays
                #region 1D Arrays
                //int[] Numbers;
                //// Refering to the default value of reference type (Null)
                //// Declare reference of type array
                //// CLR will allocate bytes at the stack for the reference (4 bytes)
                //// CLR will allocate 0 bytes at heap
                //Numbers = new int[3]; //Allocate 12 bytes at heap
                //// Initialization with default value of 0
                //Console.WriteLine(Numbers[0]);
                //Numbers[0] = 1;
                //Numbers[1] = 2;
                //Numbers[2] = 3;
                //Console.WriteLine(Numbers[0]);
                //int[] Numbers2 = new int[3] { 1, 2, 3 };
                //Console.WriteLine(Numbers2[1]);
                //int[] Numbers3 = new int[] { 1, 2 };
                //int[] Numbers4 = { 1, 2, 3, 4, 5 };
                //Console.WriteLine($"Size of array is: {Numbers4.Length}, Number of Dimension is: {Numbers4.Rank}");
                //for ( int i = 0; i < Numbers4.Length; i++ )
                //{
                //    Console.WriteLine(Numbers4[i]);
                //}
                #endregion
                #region 2D Arrays
                //int[,] Marks = new int[3, 5] { { 55, 66, 77, 88, 99 }, { 55, 66, 77, 88, 99 }, { 55, 66, 77, 88, 99 } };
                //// new => Allocate required bytes at heap  15 * 4  = 60 Byte
                //Console.WriteLine($"Size of Array = {Marks.Length}, Dimension = {Marks.Rank}");

                //int[,] Marks = new int[2, 4];
                //Console.WriteLine(Marks.GetLength(0));
                //Console.WriteLine(Marks.GetLength(1));
                //for (int i = 0; i < Marks.GetLength(0); i++)
                //{
                //    Console.WriteLine($"Enter Marks of Student {i+1}");
                //    for (int j = 0; j < Marks.GetLength(1); j++)
                //    {
                //        Console.WriteLine($"Enter Sub Num {j+1}");
                //        Marks[i,j] = int.Parse(Console.ReadLine());
                //    }
                //}
                //for (int i = 0; i < Marks.GetLength(0); i++)
                //{
                //    Console.WriteLine($"Grades of Student {i+1}:");
                //    for (int j = 0; j < Marks.GetLength(1); j++)
                //    {
                //        Console.WriteLine($"Grade of Subject {j+1}: ");
                //        Console.WriteLine(Marks[i,j]);
                //    }
                //}
                #endregion
                #region Judged Arrays
                // Is a one D array of arrays with different sizes
                //int[][] Numbers = new int[3][];
                //Numbers[0] = new int[] { 1, 2, 3 };
                //Numbers[1] = new int[] { 4, 5 };
                //Numbers[2] = new int[] { 6 };
                ////Print
                //for (int i = 0; i < Numbers.Length; i++)
                //{
                //    for (int j = 0; j < Numbers[i].Length; j++)
                //    {
                //        Console.WriteLine(Numbers[i][j]);
                //    }
                //}


                #endregion
                #region Arrays Methods
                //int[] Nums = { 5, 1, 5, 4, 3, 10, 7 };
                //int[] Arr01 = { 1, 2, 3 };
                //int[] Arr02 = new int[5];
                #region Class Member Methods [Statics Methods]
                //Array.Sort(Nums);
                //Array.Copy(Arr01, Arr02, 2);
                //foreach (int i in Arr02)
                //{
                //    Console.WriteLine(i);
                //}
                //Array.Clear(Nums);
                //Array.ConstrainedCopy(Arr01, 1, Arr02, 1, 2);
                //int[] Arr03 = (int[])Array.CreateInstance(typeof(int), 10); // new int[10] 
                //int[,,] Arr04 = (int[,,])Array.CreateInstance(typeof(int), 2,4,3);
                #endregion
                #region Object Member Method
                //Arr01.CopyTo(Arr02, 1);
                //foreach (int i in Arr02)
                //{
                //    Console.WriteLine(i);
                //}
                //Arr01.SetValue(100, 1);
                //Console.WriteLine(Arr01[1]);

                #endregion
                #endregion
                #endregion
                #region Functions
                /*Program.*/Print(5,"@_@");
                PrintPattern(6);
                PrintPattern(Pattern: "):", count: 6);
                #endregion

        }
    }
}
